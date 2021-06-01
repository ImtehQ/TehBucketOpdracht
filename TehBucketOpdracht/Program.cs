using ContainerBackend.Models;
using System;
using System.Collections.Generic;

namespace TehBucketOpdracht
{


    class Program
    {
        enum ContainerType
        {
            Bucket,
            RainBarrel,
            OilBarrel
        }

        static List<Bucket> buckets = new List<Bucket>();
        static List<OilBarrel> OilBarrels = new List<OilBarrel>();
        static List<RainBarrel> RainBarrels = new List<RainBarrel>();

        //public static void CreateBarrel()
        //{
        //    ContainerType containerType = GetContainerType();
        //    Console.WriteLine($"Selected Container type: {containerType}");

        //    Console.WriteLine($"=====================================");
        //    if (containerType != ContainerType.OilBarrel)
        //    {
        //        Console.WriteLine($"Please set the capacity of the {containerType}");
        //    }
        //    else
        //    {
        //        Console.WriteLine($"A oil barrel always has a fixed capacity.");
        //    }
        //    int capacity = 0;
        //    if (containerType == ContainerType.Bucket)
        //    {
        //        Console.WriteLine("Range: 10-12");
        //        capacity = GetCapacity();
        //    }
        //    else if (containerType == ContainerType.RainBarrel)
        //    {
        //        capacity = (int)GetRainBarrelSize();
        //    }
        //    Console.WriteLine($"=====================================");

        //    Console.WriteLine($"Please set the starting content amount of the {containerType}");
        //    int content = GetCapacity();

        //    if (containerType == ContainerType.Bucket)
        //    {
        //        Bucket bucket = new Bucket(capacity, content);
        //        bucket.OnContainerOverflow += Bucket_OnContainerOverflow;
        //        buckets.Add(bucket);

        //        content = bucket.Content; 
        //        capacity = bucket.Capacity;
        //    }
        //    else if (containerType == ContainerType.RainBarrel)
        //    {
        //        RainBarrels.Add(new RainBarrel((RainBarrelSize)capacity, content));
        //        content = RainBarrels[RainBarrels.Count - 1].Content;
        //        capacity = RainBarrels[RainBarrels.Count - 1].Capacity;
        //    }
        //    else if (containerType == ContainerType.OilBarrel)
        //    {
        //        capacity = 159;
        //        OilBarrels.Add(new OilBarrel(content));
        //        content = OilBarrels[OilBarrels.Count - 1].Content;
        //        capacity = OilBarrels[OilBarrels.Count - 1].Capacity;
        //    }

        //    Console.WriteLine($"New container: {containerType}");
        //    Console.WriteLine($"Capacity: {capacity}");
        //    Console.WriteLine($"Content: {content}");
        //    Console.WriteLine($"=====================================");
        //    Console.WriteLine($"There are currently:");
        //    Console.WriteLine($"{buckets.Count} buckets");
        //    Console.WriteLine($"{RainBarrels.Count} rainbarrels");
        //    Console.WriteLine($"{OilBarrels.Count} oilbarrels");
        //    Console.WriteLine($"=====================================");

        //    Console.WriteLine($"Would you like to add a new container?");
        //    bool repeat = GetYesNoReply();
        //    if (repeat == true)
        //        CreateBarrel();
        //    else
        //        return;
        //}

        //private static bool GetYesNoReply()
        //{
        //    Console.WriteLine($"Press 'Y' = Yes,  'N' = No");
        //    string input = Console.ReadLine();
        //    if (input.Length == 1)
        //    {
        //        if (input == "Y" || input == "y")
        //        {
        //            return true;
        //        }
        //        else if (input == "N" || input == "n")
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return GetYesNoReply();
        //        }
        //    }

        //    Console.WriteLine("Invalid input!");
        //    return GetYesNoReply();
        //}

        //private static int GetCapacity()
        //{
        //    string Input = Console.ReadLine();

        //    try
        //    {
        //        int result = Int32.Parse(Input);
        //        return result;
        //    }
        //    catch (FormatException)
        //    {
        //        Console.WriteLine("Invalid input!");
        //        return GetCapacity();
        //    }

        //    return 0;
        //}

        //private static ContainerType GetContainerType()
        //{
        //    Console.WriteLine("What type of container would you like?");
        //    Console.WriteLine($"0: {(ContainerType)0}, 1: {(ContainerType)1}, 2: {(ContainerType)2}");
        //    string ContainerTypeInput = Console.ReadLine();
        //    if (ContainerTypeInput.Length == 1)
        //    {
        //        try
        //        {
        //            int result = Int32.Parse(ContainerTypeInput);
        //            if (result < Enum.GetNames(typeof(ContainerType)).Length)
        //            {
        //                return (ContainerType)result;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Invalid input!");
        //                return GetContainerType();
        //            }
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Invalid input!");
        //            return GetContainerType();
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input!");
        //        return GetContainerType();
        //    }
        //    return ContainerType.Bucket;
        //}

        //private static RainBarrelSize GetRainBarrelSize()
        //{
        //    Console.WriteLine("Please select a Rain barrel size:");
        //    Console.WriteLine($"0: {RainBarrelSize.small}, 1: {RainBarrelSize.medium}, 2: {RainBarrelSize.large}");
        //    string RainBarrelSizeInput = Console.ReadLine();
        //    if (RainBarrelSizeInput.Length == 1)
        //    {
        //        try
        //        {
        //            int result = Int32.Parse(RainBarrelSizeInput);
        //            if (result < Enum.GetNames(typeof(ContainerType)).Length)
        //            {
        //                return (RainBarrelSize)result;
        //            }
        //            else
        //            {
        //                Console.WriteLine("Invalid input!");
        //                return GetRainBarrelSize();
        //            }
        //        }
        //        catch (FormatException)
        //        {
        //            Console.WriteLine("Invalid input!");
        //            return GetRainBarrelSize();
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Invalid input!");
        //        return GetRainBarrelSize();
        //    }
        //    return RainBarrelSize.small;
        //}

        private static void Bucket_OnContainerOverflow(object sender, int overflowAmount)
        {
            Console.WriteLine($"sender ID: {((Container)sender).Id} Overflow: {overflowAmount}");
        }


        static void Main(string[] args)
        {
            Console.WriteLine("Hello Container World!");
            //CreateBarrel();
            Console.ReadLine();

            for (int i = 0; i < 5; i++)
            {
                Bucket bucket = new Bucket(10, 10);
                bucket.OnContainerOverflow += Bucket_OnContainerOverflow;
                bucket.Id = i;
                buckets.Add(bucket);
            }

            for (int i = 0; i < buckets.Count; i++)
            {
                Console.WriteLine($"Bucket: {i}");
                buckets[i].Fill(500);
            }
            Console.ReadLine();
        }


    }
}
