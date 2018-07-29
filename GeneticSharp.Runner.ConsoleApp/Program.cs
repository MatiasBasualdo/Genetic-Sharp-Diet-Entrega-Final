using System;
using System.Collections.Generic;
using System.IO;
using GeneticSharp.Domain;
using GeneticSharp.Domain.Populations;
using GeneticSharp.Infrastructure.Framework.Reflection;
using Newtonsoft.Json;

namespace GeneticSharp.Runner.ConsoleApp
{
    public class Program
    {
        public static string archivoResultadosTotales = @"c:\Genetic\Resultados\LogResultados.csv";

        public static object ConfigurationManager { get; private set; }

        public static Int32 cantidadMinima { get; set; }
        public static Int32 cantidadMaxima { get; set; }
        public static Int32 numeroGeneracion { get; set; }

        public static int Grasa { get; set; }

        public static int Proteina { get; set; }

        public static int Calorias { get; set; }

        public static int Carbohidrato { get; set; }

        public static void Main(string[] args)
        {

            if (args.Length == 0)
            {
                System.Console.WriteLine("Por favor ingrese un argumento");
                return;
            }

            if (args.Length != 7)
            {
                System.Console.WriteLine("La cantidad de argumentos es incorrecta");
                return;
            }

            cantidadMinima = Int32.Parse(args[0]);
            cantidadMaxima = Int32.Parse(args[1]);
            numeroGeneracion = Int32.Parse(args[2]);

            Grasa = Int32.Parse(args[3]);
            Proteina = Int32.Parse(args[4]);
            Calorias = Int32.Parse(args[5]);
            Carbohidrato = Int32.Parse(args[6]);         

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(archivoResultadosTotales, true))
            {
                file.WriteLine("Ingreso Inicio");
                file.WriteLine(String.Format("Cantidad minima, {0}", cantidadMinima.ToString()));
                file.WriteLine(String.Format("Cantidad maxima, {0}", cantidadMaxima.ToString()));
                file.WriteLine(String.Format("Cantidad generaciones, {0}", numeroGeneracion.ToString()));
                file.WriteLine("");
                file.WriteLine(String.Format("Valores Agente anterior"));
                file.WriteLine(String.Format("Grasa, {0}", Grasa.ToString()));
                file.WriteLine(String.Format("Proteina, {0}", Proteina.ToString()));
                file.WriteLine(String.Format("Carbohidrato, {0}", Carbohidrato.ToString()));
                file.WriteLine(String.Format("Calorias, {0}", Calorias.ToString()));
                file.WriteLine("Resultados corridas");
                file.WriteLine(String.Format("Aptitud,Seleccion,Cruzamiento,Mutacion,IdFood, GEN 1, IdFood, GEN 2, IdFood, GEN 3, IdFood, GEN 4, IdFood, GEN 5"));
            }

            try
            {
                Run1(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run2(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run3(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run4(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run5(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run6(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run7(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run8(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run9(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run10(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run11(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run12(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run13(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run14(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run15(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }

            try
            {
                Run16(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run17(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run18(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run19(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run20(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run21(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run22(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run23(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run24(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run25(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run26(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run27(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run28(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run29(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run30(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
            try
            {
                Run31(cantidadMinima, cantidadMaxima, numeroGeneracion);
            }
            catch
            {

            }
        }

        #region Selection 

        private static void Run1(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.EliteSelection();
            var crossover = new Domain.Crossovers.UniformCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run2(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.RouletteWheelSelection();
            var crossover = new Domain.Crossovers.UniformCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run3(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.StochasticUniversalSamplingSelection();
            var crossover = new Domain.Crossovers.UniformCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run4(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.TournamentSelection();
            var crossover = new Domain.Crossovers.UniformCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        #endregion

        #region Selection CroosOver

        private static void Run5(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.EliteSelection();
            var crossover = new Domain.Crossovers.CutAndSpliceCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run6(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.EliteSelection();
            var crossover = new Domain.Crossovers.OnePointCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run7(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.EliteSelection();
            var crossover = new Domain.Crossovers.OrderedCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }


        private static void Run8(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.EliteSelection();
            var crossover = new Domain.Crossovers.TwoPointCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run9(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.EliteSelection();
            var crossover = new Domain.Crossovers.ThreeParentCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        #endregion

        #region Mutation

        private static void Run10(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.EliteSelection();
            var crossover = new Domain.Crossovers.PartiallyMappedCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }


        private static void Run11(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.EliteSelection();
            var crossover = new Domain.Crossovers.UniformCrossover();
            var mutation = new Domain.Mutations.InsertionMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }


        private static void Run12(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.EliteSelection();
            var crossover = new Domain.Crossovers.UniformCrossover();
            var mutation = new Domain.Mutations.TworsMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run13(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.EliteSelection();
            var crossover = new Domain.Crossovers.UniformCrossover();
            var mutation = new Domain.Mutations.PartialShuffleMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run14(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.EliteSelection();
            var crossover = new Domain.Crossovers.UniformCrossover();
            var mutation = new Domain.Mutations.FlipBitMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }
        #endregion


        private static void Run15(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.RouletteWheelSelection();
            var crossover = new Domain.Crossovers.CutAndSpliceCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }


        private static void Run16(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.RouletteWheelSelection();
            var crossover = new Domain.Crossovers.OnePointCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run17(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.RouletteWheelSelection();
            var crossover = new Domain.Crossovers.OrderedCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run18(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.RouletteWheelSelection();
            var crossover = new Domain.Crossovers.TwoPointCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run19(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.RouletteWheelSelection();
            var crossover = new Domain.Crossovers.ThreeParentCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run20(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.RouletteWheelSelection();
            var crossover = new Domain.Crossovers.PartiallyMappedCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run21(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.TournamentSelection();
            var crossover = new Domain.Crossovers.UniformCrossover();
            var mutation = new Domain.Mutations.PartialShuffleMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run22(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.TournamentSelection();
            var crossover = new Domain.Crossovers.UniformCrossover();
            var mutation = new Domain.Mutations.PartialShuffleMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run23(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.TournamentSelection();
            var crossover = new Domain.Crossovers.UniformCrossover();
            var mutation = new Domain.Mutations.PartialShuffleMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run24(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.TournamentSelection();
            var crossover = new Domain.Crossovers.UniformCrossover();
            var mutation = new Domain.Mutations.PartialShuffleMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run25(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.TournamentSelection();
            var crossover = new Domain.Crossovers.UniformCrossover();
            var mutation = new Domain.Mutations.PartialShuffleMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run26(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.StochasticUniversalSamplingSelection();
            var crossover = new Domain.Crossovers.CutAndSpliceCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }


        private static void Run27(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.StochasticUniversalSamplingSelection();
            var crossover = new Domain.Crossovers.OnePointCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run28(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.StochasticUniversalSamplingSelection();
            var crossover = new Domain.Crossovers.OrderedCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run29(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.StochasticUniversalSamplingSelection();
            var crossover = new Domain.Crossovers.TwoPointCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run30(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.StochasticUniversalSamplingSelection();
            var crossover = new Domain.Crossovers.ThreeParentCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        private static void Run31(Int32 cantidadMinima, Int32 cantidadMaxima, Int32 numeroGeneracion)
        {
            var selection = new Domain.Selections.StochasticUniversalSamplingSelection();
            var crossover = new Domain.Crossovers.PartiallyMappedCrossover();
            var mutation = new Domain.Mutations.UniformMutation();
            var fitness = new Extensions.GeneticDiet.GeneticDietFitness(Grasa, Proteina, Calorias, Carbohidrato);
            var chromosome = new Extensions.GeneticDiet.GeneticDietChromosome();

            var population = new GeneticSharp.Extensions.GeneticDiet.GeneticDietPopulation(cantidadMinima, cantidadMaxima, chromosome);

            GeneticAlgorithm ga = new GeneticAlgorithm(population, fitness, selection, crossover, mutation);
            ga.Termination = new Domain.Terminations.GenerationNumberTermination(numeroGeneracion);

            RegistrarResultados(ga);
        }

        public static void RegistrarResultados(GeneticAlgorithm ga)
        {
            

            String nombreSeleccion = ga.Selection.ToString().Replace("GeneticSharp.Domain.Selections", "");
            String nombreCruzamiento = ga.Crossover.ToString().Replace("GeneticSharp.Domain.Crossovers", "");
            String nombreMutacion = ga.Mutation.ToString().Replace("GeneticSharp.Domain.Mutations", "");

            String Ticks = DateTime.Now.Ticks.ToString();

            string archivoResultadosTotales = @"c:\Genetic\Resultados\LogResultados.csv";
            string archivoResultados = @"c:\Genetic\Resultados\" + Ticks + "_" + nombreSeleccion + "_" + nombreCruzamiento + "_" + nombreMutacion + "_LogResultados.txt";
            string archivoResultadosGeneraciones = @"c:\Genetic\Resultados\" + Ticks + "_" + nombreSeleccion + "_" + nombreCruzamiento + "_" + nombreMutacion + "_LogExcel.csv";            

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(archivoResultados, true))
            {

                file.WriteLine(String.Format("GA running..."));
                ga.Start();

                using (System.IO.StreamWriter fileResultado =
                    new System.IO.StreamWriter(archivoResultadosTotales, true))
                {
                    try
                    {
                        fileResultado.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10},{11},{12},{13}", 
                            ga.BestChromosome.Fitness.ToString(), 
                            nombreSeleccion, 
                            nombreCruzamiento, 
                            nombreMutacion,
                            ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).IdFood,
                            ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).NameFood.Replace(',', ' '),
                            ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).IdFood,
                            ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).NameFood.Replace(',', ' '),
                            ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).IdFood,
                            ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).NameFood.Replace(',', ' '),
                            ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).IdFood,
                            ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).NameFood.Replace(',', ' '),
                            ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).IdFood,
                            ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).NameFood.Replace(',', ' ')
                            ));


                    }
                    catch (Exception ex)
                    {

                    }
                }

                file.WriteLine(String.Format("---------------------------------------------------------------------------------------------"));
                file.WriteLine(String.Format("Mejor valor en funcion de aptitud= {0}.", ga.BestChromosome.Fitness));
                file.WriteLine("");

                file.WriteLine(String.Format("Cantidad de generaciones= {0}", ga.Population.GenerationsNumber));

                file.WriteLine(String.Format("Seleccion= {0}", ga.Selection.ToString().Replace("GeneticSharp.Domain.Selections.", "")));
                file.WriteLine(String.Format("Cruzamiento= {0}", ga.Crossover.ToString().Replace("GeneticSharp.Domain.Crossovers.", "")));
                file.WriteLine(String.Format("Mutacion= {0}", ga.Mutation.ToString().Replace("GeneticSharp.Domain.Mutations.", "")));

                file.WriteLine(String.Format("Cantidad minima, {0}", cantidadMinima.ToString()));
                file.WriteLine(String.Format("Cantidad maxima, {0}", cantidadMaxima.ToString()));
                file.WriteLine(String.Format("Cantidad generaciones, {0}", numeroGeneracion.ToString()));
                
                file.WriteLine(String.Format("Valores Agente anterior"));
                file.WriteLine(String.Format("Grasa, {0}", Grasa.ToString()));
                file.WriteLine(String.Format("Proteina, {0}", Proteina.ToString()));
                file.WriteLine(String.Format("Carbohidrato, {0}", Carbohidrato.ToString()));
                file.WriteLine(String.Format("Calorias, {0}", Calorias.ToString()));


                file.WriteLine("");
                file.WriteLine(String.Format("GEN 1 ------------------------------------------------------------------------------------------"));
                file.WriteLine(String.Format("IdFood= {0}, Nombre= {1}, NumeroGen= {2}", ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).IdFood, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).NameFood, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).NumberGen));
                file.WriteLine(String.Format("Nutrientes ------------------------------------------------------------------------------------------"));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[0].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[0].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[0].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[1].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[1].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[1].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[2].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[2].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[2].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[3].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[3].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[3].ValueNutrient));
                file.WriteLine(String.Format("GEN 2 ------------------------------------------------------------------------------------------"));
                file.WriteLine(String.Format("IdFood={0}, Nombre={1}, NumeroGen={2}", ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).IdFood, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).NameFood, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).NumberGen));
                file.WriteLine(String.Format("Nutrientes ------------------------------------------------------------------------------------------"));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[0].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[0].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[0].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[1].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[1].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[1].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[2].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[2].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[2].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[3].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[3].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[3].ValueNutrient));
                file.WriteLine(String.Format("GEN 3 ------------------------------------------------------------------------------------------"));
                file.WriteLine(String.Format("IdFood={0}, Nombre={1}, NumeroGen={2}", ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).IdFood, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).NameFood, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).NumberGen));
                file.WriteLine(String.Format("Nutrientes ------------------------------------------------------------------------------------------"));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[0].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[0].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[0].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[1].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[1].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[1].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[2].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[2].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[2].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[3].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[3].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[3].ValueNutrient));
                file.WriteLine(String.Format("GEN 4 ------------------------------------------------------------------------------------------"));
                file.WriteLine(String.Format("IdFood={0}, Nombre={1}, NumeroGen={2}", ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).IdFood, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).NameFood, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).NumberGen));
                file.WriteLine(String.Format("Nutrientes ------------------------------------------------------------------------------------------"));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[0].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[0].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[0].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[1].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[1].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[1].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[2].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[2].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[2].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[3].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[3].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[3].ValueNutrient));
                file.WriteLine(String.Format("GEN 5 ------------------------------------------------------------------------------------------"));
                file.WriteLine(String.Format("IdFood={0}, Nombre={1}, NumeroGen={2}", ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).IdFood, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).NameFood, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).NumberGen));
                file.WriteLine(String.Format("Nutrientes ------------------------------------------------------------------------------------------"));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[0].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[0].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[0].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[1].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[1].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[1].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[2].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[2].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[2].ValueNutrient));
                file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[3].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[3].NutrientName, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[3].ValueNutrient));

                file.WriteLine(String.Format("-------------------------------------------------------------------------------------------------------------------------------------------------------------"));
                file.WriteLine(String.Format("-------------------------------------------------------------------------------------------------------------------------------------------------------------"));

                var listaGeneraciones = (List<GeneticSharp.Domain.Populations.Generation>)ga.Population.Generations;
                //file.WriteLine(JsonConvert.SerializeObject(listaGeneraciones));

                foreach (var generacion in listaGeneraciones)
                {

                    file.WriteLine(String.Format("#####################################################################################################"));
                    file.WriteLine(String.Format("Generacion numero = {0}", generacion.Number));
                    file.WriteLine(String.Format("---------------------------------------------------------------------------------------------"));
                    file.WriteLine(String.Format("Mejor valor en funcion de aptitud= {0}.", generacion.BestChromosome.Fitness));
                    file.WriteLine("");
                    file.WriteLine(String.Format("GEN 1 ------------------------------------------------------------------------------------------"));
                    file.WriteLine(String.Format("IdFood= {0}, Nombre= {1}, NumeroGen= {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).IdFood, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).NameFood, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).NumberGen));
                    file.WriteLine(String.Format("Nutrientes ------------------------------------------------------------------------------------------"));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[0].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[0].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[0].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[1].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[1].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[1].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[2].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[2].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[2].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[3].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[3].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[3].ValueNutrient));
                    file.WriteLine(String.Format("GEN 2 ------------------------------------------------------------------------------------------"));
                    file.WriteLine(String.Format("IdFood={0}, Nombre={1}, NumeroGen={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).IdFood, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).NameFood, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).NumberGen));
                    file.WriteLine(String.Format("Nutrientes ------------------------------------------------------------------------------------------"));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[0].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[0].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[0].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[1].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[1].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[1].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[2].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[2].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[2].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[3].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[3].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[3].ValueNutrient));
                    file.WriteLine(String.Format("GEN 3 ------------------------------------------------------------------------------------------"));
                    file.WriteLine(String.Format("IdFood={0}, Nombre={1}, NumeroGen={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).IdFood, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).NameFood, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).NumberGen));
                    file.WriteLine(String.Format("Nutrientes ------------------------------------------------------------------------------------------"));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[0].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[0].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[0].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[1].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[1].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[1].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[2].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[2].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[2].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[3].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[3].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[3].ValueNutrient));
                    file.WriteLine(String.Format("GEN 4 ------------------------------------------------------------------------------------------"));
                    file.WriteLine(String.Format("IdFood={0}, Nombre={1}, NumeroGen={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).IdFood, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).NameFood, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).NumberGen));
                    file.WriteLine(String.Format("Nutrientes ------------------------------------------------------------------------------------------"));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[0].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[0].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[0].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[1].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[1].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[1].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[2].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[2].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[2].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[3].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[3].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[3].ValueNutrient));
                    file.WriteLine(String.Format("GEN 5 ------------------------------------------------------------------------------------------"));
                    file.WriteLine(String.Format("IdFood={0}, Nombre={1}, NumeroGen={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).IdFood, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).NameFood, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).NumberGen));
                    file.WriteLine(String.Format("Nutrientes ------------------------------------------------------------------------------------------"));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[0].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[0].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[0].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[1].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[1].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[1].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[2].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[2].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[2].ValueNutrient));
                    file.WriteLine(String.Format("Id={0}, Nombre={1}, Valor={2}", ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[3].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[3].NutrientName, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[3].ValueNutrient));

                }

            }

            using (System.IO.StreamWriter file =
            new System.IO.StreamWriter(archivoResultadosGeneraciones, true))
            {

                ga.Start();

                file.WriteLine(String.Format("Cantidad minima, {0}", cantidadMinima.ToString()));
                file.WriteLine(String.Format("Cantidad maxima, {0}", cantidadMaxima.ToString()));
                file.WriteLine(String.Format("Cantidad generaciones, {0}", numeroGeneracion.ToString()));
                
                file.WriteLine(String.Format("Valores Agente anterior"));
                file.WriteLine(String.Format("Grasa, {0}", Grasa.ToString()));
                file.WriteLine(String.Format("Proteina, {0}", Proteina.ToString()));
                file.WriteLine(String.Format("Carbohidrato, {0}", Carbohidrato.ToString()));
                file.WriteLine(String.Format("Calorias, {0}", Calorias.ToString()));

                file.WriteLine(String.Format(""));
                file.WriteLine(String.Format("Mejor Aptitud, {0}", ga.BestChromosome.Fitness));
                file.WriteLine("");

                file.WriteLine(String.Format("Cantidad de generaciones, {0}", ga.Population.GenerationsNumber));

                file.WriteLine(String.Format("Seleccion, {0}", nombreSeleccion));
                file.WriteLine(String.Format("Cruzamiento, {0}", nombreCruzamiento));
                file.WriteLine(String.Format("Mutacion, {0}", nombreMutacion));

                file.WriteLine("");
                file.WriteLine(String.Format("GEN 1, IdFood, Nombre, NumeroGen ,Nutrientes, IdNutriente, Nombre Nutriente, Valor "));
                file.WriteLine(String.Format(",{0}, {1}, {2}, , {3}, {4}, {5} ", ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).IdFood, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).NameFood.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).NumberGen, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[0].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[0].NutrientName.ToString().Replace(',', ' ').ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[0].ValueNutrient));
                //file.WriteLine(String.Format(",,Nutrientes, Id, Nombre, Valor"));
                //file.WriteLine(String.Format(",,,,,", ));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[1].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[1].NutrientName.ToString().Replace(',', ' ').ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[1].ValueNutrient));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[2].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[2].NutrientName.ToString().Replace(',', ' ').ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[2].ValueNutrient));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[3].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[3].NutrientName.ToString().Replace(',', ' ').ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(0).Value).listNutrient[3].ValueNutrient));
                file.WriteLine(String.Format("GEN 2, IdFood, Nombre, NumeroGen ,Nutrientes, IdNutriente, Nombre Nutriente, Valor "));
                file.WriteLine(String.Format(",{0}, {1}, {2}, , {3}, {4}, {5} ", ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).IdFood, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).NameFood.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).NumberGen, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[0].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[0].NutrientName.ToString().Replace(',', ' ').ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[0].ValueNutrient));
                //file.WriteLine(String.Format(",,Nutrientes, Id, Nombre, Valor"));
                //file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[1].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[1].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[1].ValueNutrient));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[2].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[2].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[2].ValueNutrient));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[3].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[3].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(1).Value).listNutrient[3].ValueNutrient));
                file.WriteLine(String.Format("GEN 3, IdFood, Nombre, NumeroGen ,Nutrientes, IdNutriente, Nombre Nutriente, Valor "));
                file.WriteLine(String.Format(",{0}, {1}, {2}, , {3}, {4}, {5} ", ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).IdFood, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).NameFood.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).NumberGen, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[0].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[0].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[0].ValueNutrient));
                //file.WriteLine(String.Format(",,Nutrientes, Id, Nombre, Valor"));
                //file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[1].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[1].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[1].ValueNutrient));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[2].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[2].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[2].ValueNutrient));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[3].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[3].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(2).Value).listNutrient[3].ValueNutrient));
                file.WriteLine(String.Format("GEN 4, IdFood, Nombre, NumeroGen ,Nutrientes, IdNutriente, Nombre Nutriente, Valor "));
                file.WriteLine(String.Format(",{0}, {1}, {2}, , {3}, {4}, {5} ", ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).IdFood, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).NameFood.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).NumberGen, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[0].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[0].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[0].ValueNutrient));
                //file.WriteLine(String.Format(",,Nutrientes, Id, Nombre, Valor"));
                //file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[1].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[1].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[1].ValueNutrient));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[2].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[2].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[2].ValueNutrient));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[3].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[3].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(3).Value).listNutrient[3].ValueNutrient));
                file.WriteLine(String.Format("GEN 5, IdFood, Nombre, NumeroGen ,Nutrientes, IdNutriente, Nombre Nutriente, Valor "));
                file.WriteLine(String.Format(",{0}, {1}, {2}, , {3}, {4}, {5} ", ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).IdFood, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).NameFood.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).NumberGen, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[0].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[0].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[0].ValueNutrient));
                //file.WriteLine(String.Format(",,Nutrientes, Id, Nombre, Valor"));
                //file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[1].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[1].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[1].ValueNutrient));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[2].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[2].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[2].ValueNutrient));
                file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[3].NutrientId, ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[3].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)ga.BestChromosome.GetGene(4).Value).listNutrient[3].ValueNutrient));

                file.WriteLine(String.Format(""));
                file.WriteLine(String.Format(""));

                var listaGeneraciones = (List<GeneticSharp.Domain.Populations.Generation>)ga.Population.Generations;
                //file.WriteLine(JsonConvert.SerializeObject(listaGeneraciones));

                foreach (var generacion in listaGeneraciones)
                {

                    file.WriteLine(String.Format(""));
                    file.WriteLine(String.Format("Generacion numero , {0}", generacion.Number));
                    file.WriteLine(String.Format(""));
                    file.WriteLine(String.Format("Mejor Aptitud, {0}", generacion.BestChromosome.Fitness));
                    file.WriteLine("");
                    file.WriteLine(String.Format("GEN 1, IdFood, Nombre, NumeroGen ,Nutrientes, IdNutriente, Nombre Nutriente, Valor "));
                    file.WriteLine(String.Format(",{0}, {1}, {2}, , {3}, {4}, {5} ", ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).IdFood, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).NameFood.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).NumberGen, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[0].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[0].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[0].ValueNutrient));
                    //file.WriteLine(String.Format(",,Nutrientes, IdNutriente, Nombre Nutriente, Valor "));
                    //file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[1].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[1].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[1].ValueNutrient));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[2].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[2].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[2].ValueNutrient));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[3].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[3].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(0).Value).listNutrient[3].ValueNutrient));
                    file.WriteLine(String.Format("GEN 2, IdFood, Nombre, NumeroGen ,Nutrientes, IdNutriente, Nombre Nutriente, Valor "));
                    file.WriteLine(String.Format(",{0}, {1}, {2}, , {3}, {4}, {5} ", ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).IdFood, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).NameFood.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).NumberGen, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[0].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[0].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[0].ValueNutrient));
                    //file.WriteLine(String.Format(",,Nutrientes, Id, Nombre, Valor"));
                    //file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[1].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[1].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[1].ValueNutrient));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[2].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[2].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[2].ValueNutrient));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[3].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[3].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(1).Value).listNutrient[3].ValueNutrient));
                    file.WriteLine(String.Format("GEN 3, IdFood, Nombre, NumeroGen ,Nutrientes, IdNutriente, Nombre Nutriente, Valor "));
                    file.WriteLine(String.Format(",{0}, {1}, {2}, , {3}, {4}, {5} ", ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).IdFood, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).NameFood.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).NumberGen, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[0].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[0].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[0].ValueNutrient));
                    //file.WriteLine(String.Format(",,Nutrientes, Id, Nombre, Valor"));
                    //file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[1].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[1].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[1].ValueNutrient));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[2].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[2].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[2].ValueNutrient));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[3].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[3].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(2).Value).listNutrient[3].ValueNutrient));
                    file.WriteLine(String.Format("GEN 4, IdFood, Nombre, NumeroGen ,Nutrientes, IdNutriente, Nombre Nutriente, Valor "));
                    file.WriteLine(String.Format(",{0}, {1}, {2}, , {3}, {4}, {5} ", ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).IdFood, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).NameFood.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).NumberGen, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[0].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[0].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[0].ValueNutrient));
                    //file.WriteLine(String.Format(",,Nutrientes, Id, Nombre, Valor"));
                    //file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[1].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[1].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[1].ValueNutrient));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[2].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[2].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[2].ValueNutrient));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[3].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[3].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(3).Value).listNutrient[3].ValueNutrient));
                    file.WriteLine(String.Format("GEN 5, IdFood, Nombre, NumeroGen ,Nutrientes, IdNutriente, Nombre Nutriente, Valor "));
                    file.WriteLine(String.Format(",{0}, {1}, {2}, , {3}, {4}, {5} ", ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).IdFood, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).NameFood.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).NumberGen, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[0].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[0].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[0].ValueNutrient));
                    //file.WriteLine(String.Format(",,Nutrientes, Id, Nombre, Valor"));
                    //file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[1].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[1].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[1].ValueNutrient));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[2].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[2].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[2].ValueNutrient));
                    file.WriteLine(String.Format(",,,,,{0}, {1}, {2}", ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[3].NutrientId, ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[3].NutrientName.ToString().Replace(',', ' '), ((EF.GenDB)generacion.BestChromosome.GetGene(4).Value).listNutrient[3].ValueNutrient));

                }

            }

        }

    }
}
