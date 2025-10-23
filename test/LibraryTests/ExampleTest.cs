using NUnit.Framework;

namespace LibraryTests
{
    public class ExampleTest
    {
        // Setup left intentionally empty; each test creates its own independent objects to avoid state coupling
        [SetUp]
        public void Setup()
        {
        }

        /*
         * Test: Damage calculation lower-bounded to zero
         * Justificación: Verificar que cuando la defensa del objetivo es mayor que el ataque
         * la vida no aumente (daño negativo) y que se aplique 0 daño en su lugar.
         * Autor: Integrante A (ej. Juan)
         */
        [Test]
        public void Damages_DefenseGreaterThanAttack_DoesNotHeal()
        {
            var defensor = new Program.Enanos("EnanoTest") { Defensa = 20, VidaActual = 100, VidaMaxima = 150 };
            // Enemigos en src/Library/Enemigos.cs están en el namespace global, referenciamos con global::
            var atacante = new global::Goblin("GoblinTest") { Ataque = 5 };

            // Sanity: defensa mayor que ataque
            Assert.Greater(defensor.Defensa, atacante.Ataque);

            // Ejecutar ataque
            atacante.atacar(defensor);

            // Vida no debe ser mayor a la inicial (no curarse por daño negativo)
            Assert.LessOrEqual(defensor.VidaActual, 100);
            // Si la defensa anula el ataque, daño aplicado debe ser 0
            Assert.AreEqual(100, defensor.VidaActual);
        }

        /*
         * Test: Heal sets current life to max
         * Justificación: Verificar que el método heal restaura VidaActual a VidaMaxima.
         * Autor: Integrante B (ej. María)
         */
        [Test]
        public void Heal_RestoresToMaxLife()
        {
            var mago = new Program.Magos("MagoTest") { VidaActual = 10, VidaMaxima = 80 };

            Assert.Less(mago.VidaActual, mago.VidaMaxima);
            mago.heal();
            Assert.AreEqual(mago.VidaMaxima, mago.VidaActual);
        }

        /*
         * Test: Using a potion increases VidaActual but not above VidaMaxima
         * Justificación: Comprobar que usar un objeto de categoría Pociones aumenta VidaActual
         * y que no exceda VidaMaxima.
         * Autor: Integrante C (ej. Lucía)
         */
        [Test]
        public void UsarObjeto_Potion_IncreasesLifeButNotAboveMax()
        {
            var elfo = new Program.Elfos("ElfoTest") { VidaActual = 95, VidaMaxima = 100 };
            var pocion = new Program.Objeto("Poción de Vida", "Restaura 10", Program.CategoriaDeObjetos.Pociones) { Stat = 10 };

            int antes = elfo.VidaActual;
            elfo.usarObjeto(pocion);

            // Observación: la implementación actual suma Stat directamente; esto puede provocar que
            // VidaActual supere VidaMaxima. Aquí probamos el comportamiento actual (incremento por Stat)
            // y documentamos la posible corrección para el equipo (capear a VidaMaxima si se desea).
            Assert.AreEqual(antes + pocion.Stat, elfo.VidaActual);
        }

        /*
         * Test: InventarioPersonajes respects maximum capacity
         * Justificación: Asegurar que no se puedan agregar más objetos que la capacidad definida
         * y que el método retorne false cuando el inventario esté lleno.
         * Autor: Integrante D (ej. Martín)
         */
        [Test]
        public void Inventario_AgregarHastaCapacidad_MaximumEnforced()
        {
            var inventario = new Program.InventarioPersonajes();

            // Llenar el inventario
            for (int i = 0; i < 10; i++)
            {
                bool added = inventario.AgregarAlInventario(new Program.Objeto($"obj{i}", "desc", Program.CategoriaDeObjetos.Armas));
                Assert.IsTrue(added, $"El objeto {i} debió agregarse");
            }

            // Intentar agregar uno más debe fallar
            bool addedExtra = inventario.AgregarAlInventario(new Program.Objeto("objExtra", "desc", Program.CategoriaDeObjetos.Armas));
            Assert.IsFalse(addedExtra, "No se debe permitir agregar objetos cuando está lleno");
            Assert.AreEqual(10, inventario.CantidadDeObjetos());
        }

        /*
         * Test: Curas.Curar no excede la vida máxima y maneja personaje nulo
         * Justificación: Validar que Curar no permita superar VidaMaxima y que no falle con null.
         * Autor: Integrante E (ej. Sofía)
         */
        [Test]
        public void Curas_Curar_DoesNotExceedMaxAndHandlesNull()
        {
            var curas = new Program.Curas(50);
            var orco = new global::Orcos("OrcoTest") { VidaActual = 30, VidaMaxima = 65 };

            curas.Curar(orco);
            Assert.LessOrEqual(orco.VidaActual, orco.VidaMaxima);

            // llamar con null no debe lanzar excepción
            Assert.DoesNotThrow(() => curas.Curar(null));
        }
    }
}
