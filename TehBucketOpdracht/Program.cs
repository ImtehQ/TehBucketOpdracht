using ContainerBackend.Models;
using ContainerBackend.Statics;
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

        private static Random r = new Random(555);

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




        static void Main(string[] args)
        {
            Console.WriteLine("Hello Container World!");
           // CreateBarrel();

            CreateAll();
            Console.WriteLine("========================");
            CountAll();
            Console.WriteLine("========================");
            FillAll();
            Console.WriteLine("========================");
            EmptyAll();
            Console.WriteLine("========================");

            Console.ReadLine();

        }

        /// <summary>
        /// Creates all random containers
        /// </summary>
        private static void CreateAll()
        {
            for (int i = 0; i < 5; i++)
            {
                Bucket bucket = new Bucket(r.Next(10, 14), r.Next(0, 15), r.NextBool());
                bucket.OnContainerOverflow += Bucket_OnContainerOverflow;
                bucket.OnContainerOverflowContainer += Bucket_OnContainerOverflowContainer;
                bucket.Id = i;
                buckets.Add(bucket);
            }
            for (int i = 0; i < 5; i++)
            {
                RainBarrel rainBarrel = new RainBarrel((RainBarrelSize)r.Next(0, 2), r.Next(0, 120));
                rainBarrel.OnContainerOverflow += RainBarrel_OnContainerOverflow;
                rainBarrel.Id = i;
                RainBarrels.Add(rainBarrel);
            }
            for (int i = 0; i < 5; i++)
            {
                OilBarrel oilBarrel = new OilBarrel();
                oilBarrel.OnContainerOverflow += OilBarrel_OnContainerOverflow;
                oilBarrel.Id = i;
                OilBarrels.Add(oilBarrel);
            }
        }



        /// <summary>
        /// Counts all the containers and display the set values.
        /// </summary>
        private static void CountAll()
        {

            Console.WriteLine("_________________________");
            Console.WriteLine($"Buckets count: {buckets.Count}");
            for (int i = 0; i < buckets.Count; i++)
            {

                Console.WriteLine("_________________________");
                Console.WriteLine($"Id: {buckets[i].Id}");
                Console.WriteLine($"Capacity: {buckets[i].Capacity}");
                Console.WriteLine($"Content: {buckets[i].Content}");
                Console.WriteLine($"IgnoreOverflow: {buckets[i].IgnoreOverflow}");
                Console.WriteLine("_________________________");
            }

            Console.WriteLine("_________________________");
            Console.WriteLine($"Rainbarrels count: {RainBarrels.Count}");
            for (int i = 0; i < RainBarrels.Count; i++)
            {
                Console.WriteLine("_________________________");
                Console.WriteLine($"Id: {RainBarrels[i].Id}");
                Console.WriteLine($"Capacity: {RainBarrels[i].Capacity}");
                Console.WriteLine($"Content: {RainBarrels[i].Content}");
                Console.WriteLine("_________________________");
            }

            Console.WriteLine("_________________________");
            Console.WriteLine($"Oilbarrels count: {OilBarrels.Count}");
            for (int i = 0; i < OilBarrels.Count; i++)
            {
                Console.WriteLine("_________________________");
                Console.WriteLine($"Id: {OilBarrels[i].Id}");
                Console.WriteLine($"Capacity: {OilBarrels[i].Capacity}");
                Console.WriteLine($"Content: {OilBarrels[i].Content}");
                Console.WriteLine("_________________________");
            }
        }

        /// <summary>
        /// Fills all the containers with random amounts
        /// </summary>
        private static void FillAll()
        {
            //Fills a bucket with a random amount
            for (int i = 0; i < buckets.Count; i++)
            {
                Console.WriteLine("===================================");
                int randomFillAmount = r.Next(0, 100);
                Console.WriteLine($"Filling Bucket Id: {i}, With {randomFillAmount}");
                buckets[i].Fill(randomFillAmount);
            }

            //Fills a RainBarrel with a random amount
            for (int i = 0; i < RainBarrels.Count; i++)
            {
                Console.WriteLine("===================================");
                int randomFillAmount = r.Next(0, 100);
                Console.WriteLine($"Filling rainbarrel Id: {i}, With {randomFillAmount}");
                RainBarrels[i].Fill(randomFillAmount);
            }

            //Fills a oilbarrel with a random amount
            for (int i = 0; i < OilBarrels.Count; i++)
            {
                Console.WriteLine("===================================");
                int randomFillAmount = r.Next(0, 100);
                Console.WriteLine($"Filling oilbarrel Id: {i}, With {randomFillAmount}");
                OilBarrels[i].Fill(randomFillAmount);
            }

            //Fills a Bucket with another bucket content all at once
            for (int i = 0; i < buckets.Count; i++)
            {
                Console.WriteLine("===================================");
                Bucket randomBucket = buckets[r.Next(0, buckets.Count - 1)];
                bool ignoreOverflow = r.Next(0, 3) == 1 ? true : false;
                Console.WriteLine($"Filling Bucket Id: {i}, With Bucket Id: {randomBucket.Id}");
                buckets[i].Fill(randomBucket, ignoreOverflow);
            }

            //Fills a Bucket with another buckets content but limited amount
            for (int i = 0; i < buckets.Count; i++)
            {
                Console.WriteLine("===================================");
                Bucket randomBucket = buckets[r.Next(0, buckets.Count - 1)];
                int randomFillAmount = r.Next(0, randomBucket.Content);
                bool ignoreOverflow = r.Next(0, 1) == 1 ? true : false;
                Console.WriteLine($"Filling Bucket Id: {i}, With Bucket Id: {randomBucket.Id}");
                buckets[i].Fill(randomBucket, randomFillAmount, ignoreOverflow);
            }
        }

        /// <summary>
        /// Empties all the containers with random amounts
        /// </summary>
        private static void EmptyAll()
        {
            //empty a bucket with a random amount
            for (int i = 0; i < buckets.Count; i++)
            {
                int randomFillAmount = r.Next(0, 100);
                Console.WriteLine($"empty Bucket Id: {i}, With {randomFillAmount}");
                buckets[i].Empty(randomFillAmount);
            }

            //empty a RainBarrel with a random amount
            for (int i = 0; i < RainBarrels.Count; i++)
            {
                int randomFillAmount = r.Next(0, 100);
                Console.WriteLine($"empty rainbarrel Id: {i}, With {randomFillAmount}");
                RainBarrels[i].Empty(randomFillAmount);
            }

            //empty a oilbarrel with a random amount
            for (int i = 0; i < OilBarrels.Count; i++)
            {
                int randomFillAmount = r.Next(0, 100);
                Console.WriteLine($"empty oilbarrel Id: {i}, With {randomFillAmount}");
                OilBarrels[i].Empty(randomFillAmount);
            }
        }


        private static void Bucket_OnContainerOverflowContainer(object sender, int overflowAmount, Container container, bool overwriteOverflow)
        {
            Console.WriteLine("**![OnContainerOverflow]!** ");
            Console.WriteLine($"[Bucket] sender ID: {((Container)sender).Id} Overflow: {overflowAmount} from Bucket Id: {container.Id}");
            Console.WriteLine($"overwriteOverflow: {overwriteOverflow}, IgnoreOverflow: {((Container)sender).IgnoreOverflow}");
            Console.WriteLine("------------------------------");
        }

        private static void Bucket_OnContainerOverflow(object sender, int overflowAmount, bool overwriteOverflow)
        {
            Console.WriteLine("**![OnContainerOverflow]!** ");
            Console.WriteLine($"[Bucket] sender ID: {((Container)sender).Id} Overflow: {overflowAmount}");
            Console.WriteLine($"overwriteOverflow: {overwriteOverflow}, IgnoreOverflow: {((Container)sender).IgnoreOverflow}");
            Console.WriteLine("------------------------------");
        }

        private static void OilBarrel_OnContainerOverflow(object sender, int overflowAmount, bool overwriteOverflow)
        {
            Console.WriteLine("**![OnContainerOverflow]!** ");
            Console.WriteLine($"[OilBarrel] sender ID: {((Container)sender).Id} Overflow: {overflowAmount}");
            Console.WriteLine($"overwriteOverflow: {overwriteOverflow}, IgnoreOverflow: {((Container)sender).IgnoreOverflow}");
            Console.WriteLine("------------------------------");
        }

        private static void RainBarrel_OnContainerOverflow(object sender, int overflowAmount, bool overwriteOverflow)
        {
            Console.WriteLine("**![OnContainerOverflow]!** ");
            Console.WriteLine($"[RainBarrel] sender ID: {((Container)sender).Id} Overflow: {overflowAmount}");
            Console.WriteLine($"overwriteOverflow: {overwriteOverflow}, IgnoreOverflow: {((Container)sender).IgnoreOverflow}");
            Console.WriteLine("------------------------------");
        }
    }
}
