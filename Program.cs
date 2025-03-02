﻿using System;
using System.Drawing;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Pastel;
using RhythmsGonnaGetYou.bin;

namespace RhythmsGonnaGetYou
{
    class Program
    {
        static void DisplayGreeting()
        {
            // Hippo from https://www.asciiart.eu/animals/other-land & Ascii text from https://www.ascii-art-generator.org/
            Console.WriteLine($"{"#     #              ".Pastel(Color.SeaGreen)}{"      ".Pastel(Color.Violet)}{" ###       ".Pastel(Color.LightSkyBlue)}{" ######                            ".Pastel(Color.MediumVioletRed)} {@"      c~~p ,---------.    ".Pastel(Color.SteelBlue)}");
            Console.WriteLine($"{"#     #  ####  ##### ".Pastel(Color.SeaGreen)}{"      ".Pastel(Color.Violet)}{"  #  ##### ".Pastel(Color.LightSkyBlue)}{" #     # ######   ##   #####  #### ".Pastel(Color.MediumVioletRed)} {@" ,---'".Pastel(Color.SteelBlue)}{"oo".Pastel(Color.ForestGreen)}{@"  )           \".Pastel(Color.SteelBlue)}");
            Console.WriteLine($"{"#     # #    # #    #".Pastel(Color.SeaGreen)}{"      ".Pastel(Color.Violet)}{"  #  #    #".Pastel(Color.LightSkyBlue)}{" #     # #       #  #    #   #     ".Pastel(Color.MediumVioletRed)} {@"(".Pastel(Color.SteelBlue)}{" O O".Pastel(Color.DimGray)}{"                  )/ ".Pastel(Color.SteelBlue)}");
            Console.WriteLine($"{"####### #    # #    #".Pastel(Color.SeaGreen)}{" #####".Pastel(Color.Violet)}{"  #  #    #".Pastel(Color.LightSkyBlue)}{" ######  #####  #    #   #    #### ".Pastel(Color.MediumVioletRed)} {@" `".Pastel(Color.SteelBlue)}{"=".Pastel(Color.WhiteSmoke)}{"^".Pastel(Color.LightPink)}{"=".Pastel(Color.WhiteSmoke)}{@"'                 /".Pastel(Color.SteelBlue)}");
            Console.WriteLine($"{"#     # #    # ##### ".Pastel(Color.SeaGreen)}{"      ".Pastel(Color.Violet)}{"  #  ##### ".Pastel(Color.LightSkyBlue)}{" #     # #      ######   #        #".Pastel(Color.MediumVioletRed)} {@"       \    ,     .   /   ".Pastel(Color.SteelBlue)}");
            Console.WriteLine($"{"#     # #    # #     ".Pastel(Color.SeaGreen)}{"      ".Pastel(Color.Violet)}{"  #  #     ".Pastel(Color.LightSkyBlue)}{" #     # #      #    #   #   #    #".Pastel(Color.MediumVioletRed)} {@"       \".Pastel(Color.DimGray)}{@"\".Pastel(Color.SteelBlue)}{@"  |-----'|  /    ".Pastel(Color.SteelBlue)}");
            Console.WriteLine($"{"#     #  ####  #     ".Pastel(Color.SeaGreen)}{"      ".Pastel(Color.Violet)}{" ### #     ".Pastel(Color.LightSkyBlue)}{" ######  ###### #    #   #    #### ".Pastel(Color.MediumVioletRed)} {@"       |".Pastel(Color.DimGray)}{"|__|".Pastel(Color.SteelBlue)}    {"|_".Pastel(Color.DimGray)}{"|__|".Pastel(Color.SteelBlue)}\n");
            Console.WriteLine($"{"############################################################################################################".Pastel(Color.DarkGoldenrod)}");
            Console.WriteLine($"{"############################################################################################################".Pastel(Color.DarkGoldenrod)}");
        }

        static void DisplayExit()
        {
            // Hippo from https://www.asciiart.eu/animals/other-land & Ascii text from https://www.ascii-art-generator.org/
            Console.WriteLine($"{"######                                    ".Pastel(Color.SeaGreen)}{" #     #                     ".Pastel(Color.LightSkyBlue)}{" ###".Pastel(Color.MediumVioletRed)} {@"      c~~p ,---------.    ".Pastel(Color.SteelBlue)}");
            Console.WriteLine($"{"#     # ######  ####   ####  #####  ##### ".Pastel(Color.SeaGreen)}{" ##   ##  ####  #####  ######".Pastel(Color.LightSkyBlue)}{" ###".Pastel(Color.MediumVioletRed)} {@" ,---'".Pastel(Color.SteelBlue)}{"oo".Pastel(Color.ForestGreen)}{@"  )           \".Pastel(Color.SteelBlue)}");
            Console.WriteLine($"{"#     # #      #    # #    # #    # #    #".Pastel(Color.SeaGreen)}{" # # # # #    # #    # #     ".Pastel(Color.LightSkyBlue)}{" ###".Pastel(Color.MediumVioletRed)} {@"(".Pastel(Color.SteelBlue)}{" O O".Pastel(Color.DimGray)}{"                  )/ ".Pastel(Color.SteelBlue)}");
            Console.WriteLine($"{"######  #####  #      #    # #    # #    #".Pastel(Color.SeaGreen)}{" #  #  # #    # #    # ##### ".Pastel(Color.LightSkyBlue)}{"  # ".Pastel(Color.MediumVioletRed)} {@" `".Pastel(Color.SteelBlue)}{"=".Pastel(Color.WhiteSmoke)}{"^".Pastel(Color.LightPink)}{"=".Pastel(Color.WhiteSmoke)}{@"'                 /".Pastel(Color.SteelBlue)}");
            Console.WriteLine($"{"#   #   #      #      #    # #####  #    #".Pastel(Color.SeaGreen)}{" #     # #    # #####  #     ".Pastel(Color.LightSkyBlue)}{"    ".Pastel(Color.MediumVioletRed)} {@"       \    ,     .   /   ".Pastel(Color.SteelBlue)}");
            Console.WriteLine($"{"#    #  #      #    # #    # #   #  #    #".Pastel(Color.SeaGreen)}{" #     # #    # #   #  #     ".Pastel(Color.LightSkyBlue)}{" ###".Pastel(Color.MediumVioletRed)} {@"       \".Pastel(Color.DimGray)}{@"\".Pastel(Color.SteelBlue)}{@"  |-----'|  /    ".Pastel(Color.SteelBlue)}");
            Console.WriteLine($"{"#     # ######  ####   ####  #    # ##### ".Pastel(Color.SeaGreen)}{" #     #  ####  #    # ######".Pastel(Color.LightSkyBlue)}{" ###".Pastel(Color.MediumVioletRed)} {@"       |".Pastel(Color.DimGray)}{"|__|".Pastel(Color.SteelBlue)}    {"|_".Pastel(Color.DimGray)}{"|__|".Pastel(Color.SteelBlue)}\n");
            Console.WriteLine($"{"############################################################################################################".Pastel(Color.DarkGoldenrod)}");
            Console.WriteLine($"{"############################################################################################################".Pastel(Color.DarkGoldenrod)}");
        }

        static char PressAnyKey(string prompt)
        {
            Console.WriteLine(prompt);
            var keyPressed = Console.ReadKey().KeyChar;
            return keyPressed;
        }

        private static string WelcomeUser()
        {
            Console.Clear();
            DisplayGreeting();

            Console.WriteLine("\nWhat is your name?");
            var name = Console.ReadLine();

            Console.WriteLine($"\nHope you are doing well today, {name}!");
            PressAnyKey("\nPress Any Key to Continue! ");

            return name;
        }

        private static void MainMenu(Bands newBand, RecordLabelContext context, string name, out bool keepGoing, out bool mangagerView)
        {
            keepGoing = true;
            Console.Clear();
            DisplayGreeting();

            mangagerView = false;
            while (keepGoing && !mangagerView)
            {
                Console.Write("\nWhat do you want to do?\n(C)reate Band\n(M)anager View\n(L)ist all Bands\n(R)emove Band\n(W)elcome Band Back\n(S)igned Bands\n(U)nsigned Bands\n(Q)uit\n: ");
                var choices = Console.ReadLine().ToUpper();

                switch (choices)
                {
                    case "C":
                        newBand.CreateBand();
                        PressAnyKey("\nPress Any Key to Continue! ");
                        Console.Clear();
                        DisplayGreeting();
                        break;
                    case "M":
                        mangagerView = EditExistingBands(mangagerView, name);
                        PressAnyKey("\nPress Any Key to Continue! ");
                        Console.Clear();
                        DisplayGreeting();
                        break;
                    case "L":
                        ListBands(context);
                        PressAnyKey("\nPress Any Key to Continue! ");
                        Console.Clear();
                        DisplayGreeting();
                        break;
                    case "R":
                        RemoveBand(context);
                        PressAnyKey("\nPress Any Key to Continue! ");
                        Console.Clear();
                        DisplayGreeting();
                        break;
                    case "W":
                        ReAddBand(context);
                        PressAnyKey("\nPress Any Key to Continue! ");
                        Console.Clear();
                        DisplayGreeting();
                        break;
                    case "S":
                        SignedBands(context);
                        PressAnyKey("\nPress Any Key to Continue! ");
                        Console.Clear();
                        DisplayGreeting();
                        break;
                    case "U":
                        UnsignedBands(context);
                        PressAnyKey("\nPress Any Key to Continue! ");
                        Console.Clear();
                        DisplayGreeting();
                        break;
                    case "Q":
                        Console.Clear();
                        DisplayExit();
                        Environment.Exit(0);
                        keepGoing = false;
                        break;
                    default:
                        Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                        PressAnyKey("\nPress Any Key to Continue! ");
                        Console.Clear();
                        DisplayGreeting();
                        break;
                }
            }
        }

        private static void ManagerMenu(Bands newBand, Albums newAlbum, Songs newSong, Musicians newMusician, Concerts newConcert, RecordLabelContext context, string name, ref bool keepGoing, ref bool mangagerView)
        {
            Console.Clear();
            DisplayGreeting();

            var promptAgain = true;
            while (promptAgain)
            {
                if (mangagerView)
                {
                    Console.Write($"\nWelcome to {"Hop".Pastel(Color.SeaGreen)}{"-".Pastel(Color.Violet)}{"Ip".Pastel(Color.LightSkyBlue)} {"Beats".Pastel(Color.MediumVioletRed)} manager view, {name}!\n\nWhat do you want to do?\n(V)iew all Albums in Band\n(A)dd New Album to Band\n(E)dit Album in Band\n(N)ew Band Member\n(C)reate Concert\n(L)ist Albums by Release Date for Band\n(G)enre Ordered List of Albums\n(S)ee All Band Members\n(P)erformances\n(M)ain Menu\n(Q)uit\n: ");
                    var choices = Console.ReadLine().ToUpper();

                    switch (choices)
                    {
                        case "V":
                            AlbumsList(context, newBand);
                            PressAnyKey("\nPress Any Key to Continue! ");
                            Console.Clear();
                            DisplayGreeting();
                            break;
                        case "A":
                            newAlbum.CreateAlbum();
                            PressAnyKey("\nPress Any Key to Continue! ");
                            Console.Clear();
                            DisplayGreeting();
                            break;
                        case "E":
                            newSong.CreateSong();
                            PressAnyKey("\nPress Any Key to Continue! ");
                            Console.Clear();
                            DisplayGreeting();
                            break;
                        case "N":
                            newMusician.CreateMusician();
                            PressAnyKey("\nPress Any Key to Continue! ");
                            Console.Clear();
                            DisplayGreeting();
                            break;
                        case "C":
                            newConcert.CreateConcert();
                            PressAnyKey("\nPress Any Key to Continue! ");
                            Console.Clear();
                            DisplayGreeting();
                            break;
                        case "L":
                            ReleaseOrder(context, newBand);
                            PressAnyKey("\nPress Any Key to Continue! ");
                            Console.Clear();
                            DisplayGreeting();
                            break;
                        case "G":
                            GenreOrder(context, newBand);
                            PressAnyKey("\nPress Any Key to Continue! ");
                            Console.Clear();
                            DisplayGreeting();
                            break;
                        case "S":
                            BandMembers(context, newBand);
                            PressAnyKey("\nPress Any Key to Continue! ");
                            Console.Clear();
                            DisplayGreeting();
                            break;
                        case "P":
                            Concerts(context, newBand);
                            PressAnyKey("\nPress Any Key to Continue! ");
                            Console.Clear();
                            DisplayGreeting();
                            break;
                        case "M":
                            MainMenu(newBand, context, name, out keepGoing, out mangagerView);
                            break;
                        case "Q":
                            Console.Clear();
                            DisplayExit();
                            Environment.Exit(0);
                            keepGoing = false;
                            break;
                        default:
                            Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                            PressAnyKey("\nPress Any Key to Continue! ");
                            Console.Clear();
                            DisplayGreeting();
                            break;
                    }
                }
            }
        }

        private static bool EditExistingBands(bool mangagerView, string name)
        {
            var correctAnswer = false;
            var correctChoice = "";
            while (!correctAnswer)
            {
                Console.WriteLine($"\nAre you sure you want to go into {"Hop".Pastel(Color.SeaGreen)}{"-".Pastel(Color.Violet)}{"Ip".Pastel(Color.LightSkyBlue)} {"Beats".Pastel(Color.MediumVioletRed)} mangager view, {name}? (Yes/No)");
                correctChoice = Console.ReadLine().ToUpper();

                if (correctChoice == "Y" || correctChoice == "YES")
                {
                    mangagerView = true;
                    break;
                }
                else if (correctChoice == "N" || correctChoice == "NO")
                {
                    mangagerView = false;
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"Your choice must be".Pastel(Color.Red)} {"Yes".Pastel(Color.Yellow)} {"or".Pastel(Color.Red)} {"No".Pastel(Color.Yellow)}{"!".Pastel(Color.Red)}");
                }
            }
            return mangagerView;
        }

        private static void ListBands(RecordLabelContext context)
        {
            Console.WriteLine($"\nBands Signed by {"Hop".Pastel(Color.SeaGreen)}{"-".Pastel(Color.Violet)}{"Ip".Pastel(Color.LightSkyBlue)} {"Beats".Pastel(Color.MediumVioletRed)}:\n");

            var signedBands = context.Bands.Where(band => band.IsSigned == true);
            foreach (var band in signedBands)
            {
                Console.WriteLine($"There is a band named {band.Name}");
            }

            Console.WriteLine($"\nBands not currently signed by {"Hop".Pastel(Color.SeaGreen)}{"-".Pastel(Color.Violet)}{"Ip".Pastel(Color.LightSkyBlue)} {"Beats".Pastel(Color.MediumVioletRed)}:\n");

            var unsignedBands = context.Bands.Where(band => band.IsSigned == false);
            foreach (var band in unsignedBands)
            {
                Console.WriteLine($"There is a band named {band.Name}");
            }
        }

        private static void RemoveBand(RecordLabelContext context)
        {
            var userTypedName = false;
            var usersBand = "";
            while (!userTypedName)
            {
                Console.WriteLine($"\nWhat band would you like to let go?\nNote: This means {"Hop".Pastel(Color.SeaGreen)}{"-".Pastel(Color.Violet)}{"Ip".Pastel(Color.LightSkyBlue)} {"Beats".Pastel(Color.MediumVioletRed)} will no longer support the selected band!");
                usersBand = Console.ReadLine();

                var isThisGoodInput = usersBand.Any(x => !char.IsNumber(x));
                if (isThisGoodInput)
                {
                    var bandExists = context.Bands.Any(band => band.Name == usersBand);
                    if (bandExists)
                    {
                        var letGoOfBand = context.Bands.FirstOrDefault(band => band.Name == usersBand);
                        letGoOfBand.IsSigned = false;
                        Console.WriteLine($"\n{$"{usersBand} was removed from studio!".Pastel(Color.Yellow)}");

                        context.SaveChanges();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                        Console.WriteLine($"{"Your choice must be an existing band".Pastel(Color.Red)}");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"Your choice must be an existing band".Pastel(Color.Red)}");
                }
            }
        }

        private static void ReAddBand(RecordLabelContext context)
        {
            var userTypedName = false;
            var usersBand = "";
            while (!userTypedName)
            {
                Console.WriteLine($"\nWhat band would you like to welcome back?\nNote: This means {"Hop".Pastel(Color.SeaGreen)}{"-".Pastel(Color.Violet)}{"Ip".Pastel(Color.LightSkyBlue)} {"Beats".Pastel(Color.MediumVioletRed)} will support the selected band again!");
                usersBand = Console.ReadLine();

                var isThisGoodInput = usersBand.Any(x => !char.IsNumber(x));
                if (isThisGoodInput)
                {
                    var bandExists = context.Bands.Any(band => band.Name == usersBand);
                    if (bandExists)
                    {
                        var letGoOfBand = context.Bands.FirstOrDefault(band => band.Name == usersBand);
                        letGoOfBand.IsSigned = true;
                        Console.WriteLine($"\n{$"{usersBand} was welcomed back to the studio!".Pastel(Color.Yellow)}");

                        context.SaveChanges();
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                        Console.WriteLine($"{"Your choice must be an existing band".Pastel(Color.Red)}");
                    }
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"Your choice must be an existing band".Pastel(Color.Red)}");
                }
            }
        }

        private static void SignedBands(RecordLabelContext context)
        {
            Console.WriteLine($"\nBands signed by {"Hop".Pastel(Color.SeaGreen)}{"-".Pastel(Color.Violet)}{"Ip".Pastel(Color.LightSkyBlue)} {"Beats".Pastel(Color.MediumVioletRed)}: \n");

            var signedBands = context.Bands.Where(band => band.IsSigned == true);
            foreach (var band in signedBands)
            {
                Console.WriteLine($"{band.Name} is a signed band");
            }
        }

        private static void UnsignedBands(RecordLabelContext context)
        {
            Console.WriteLine($"\nBands not signed by {"Hop".Pastel(Color.SeaGreen)}{"-".Pastel(Color.Violet)}{"Ip".Pastel(Color.LightSkyBlue)} {"Beats".Pastel(Color.MediumVioletRed)}: \n");

            var unsignedBands = context.Bands.Where(band => band.IsSigned == false);
            foreach (var band in unsignedBands)
            {
                Console.WriteLine($"{band.Name} is an unsigned band");
            }
        }

        private static void AlbumsList(RecordLabelContext context, Bands newBand)
        {
            var userTypedName = false;
            while (!userTypedName)
            {
                Console.WriteLine($"\nWhich band's albums would you like to view?");
                var usersBand = Console.ReadLine();

                var bandExists = context.Bands.Any(band => band.Name == usersBand);
                if (bandExists)
                {
                    newBand = context.Bands.FirstOrDefault(band => band.Name == usersBand);
                    Console.WriteLine($"\n{$"{newBand.Name}'s".Pastel(Color.Yellow)} Albums:\n");

                    foreach (var album in context.Albums.Include(album => album.Band).Where(album => album.Band == newBand).OrderBy(album => album.Title))
                    {
                        Console.WriteLine($"{newBand.Name} has an album named {album.Title}");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"You must select a band!".Pastel(Color.Red)}");
                }
            }
        }

        private static void ReleaseOrder(RecordLabelContext context, Bands newBand)
        {
            var userTypedName = false;
            while (!userTypedName)
            {
                Console.WriteLine($"\nWhich band's albums would you like to view?");
                var usersBand = Console.ReadLine();

                var bandExists = context.Bands.Any(band => band.Name == usersBand);
                if (bandExists)
                {
                    newBand = context.Bands.FirstOrDefault(band => band.Name == usersBand);
                    Console.WriteLine($"\n{$"{newBand.Name}'s".Pastel(Color.Yellow)} Albums Listed in Release Order:\n");

                    foreach (var album in context.Albums.Include(album => album.Band).Where(album => album.Band == newBand).OrderBy(album => album.ReleaseDate))
                    {
                        Console.WriteLine($"{newBand.Name} has an album named {album.Title} that was released on {album.ReleaseDate.ToLongDateString()}");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"You must select a band!".Pastel(Color.Red)}");
                }
            }
        }

        private static void GenreOrder(RecordLabelContext context, Bands newBand)
        {
            var userTypedName = false;
            while (!userTypedName)
            {
                Console.WriteLine($"\nWhich genre would you like to view?");
                var usersStyle = Console.ReadLine();

                var styleExists = context.Bands.Any(band => band.Style == usersStyle);
                if (styleExists)
                {
                    newBand = context.Bands.FirstOrDefault(band => band.Style == usersStyle);

                    Console.WriteLine($"\n{"Hop".Pastel(Color.SeaGreen)}{"-".Pastel(Color.Violet)}{"Ip".Pastel(Color.LightSkyBlue)} {"Beats".Pastel(Color.MediumVioletRed)} {usersStyle} Albums:\n");
                    foreach (var album in context.Albums.Include(album => album.Band).Where(album => album.Band == newBand))
                    {
                        Console.WriteLine($"{newBand.Name} has an album named {album.Title}");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"You must select a band!".Pastel(Color.Red)}");
                }
            }
        }

        private static void BandMembers(RecordLabelContext context, Bands newBand)
        {
            var userTypedName = false;
            while (!userTypedName)
            {
                Console.WriteLine($"\nWhich band's members would you like to view?");
                var usersBand = Console.ReadLine();

                var bandExists = context.Bands.Any(band => band.Name == usersBand);
                if (bandExists)
                {
                    newBand = context.Bands.FirstOrDefault(band => band.Name == usersBand);

                    Console.WriteLine($"\n{$"{newBand.Name}'s".Pastel(Color.Yellow)} Current Members:\n");
                    foreach (var member in context.Musicians.Include(members => members.Band).Where(members => members.Band == newBand && members.CurrentMember == true).OrderBy(members => members.Name))
                    {
                        Console.WriteLine($"{newBand.Name} has a member named {member.Name}");
                    }

                    Console.WriteLine($"\n{$"{newBand.Name}'s".Pastel(Color.Yellow)} Past Members:\n");
                    foreach (var member in context.Musicians.Include(members => members.Band).Where(members => members.Band == newBand && members.CurrentMember == false).OrderBy(members => members.Name))
                    {
                        Console.WriteLine($"{newBand.Name} had a member named {member.Name}");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"You must select a band!".Pastel(Color.Red)}");
                }
            }
        }

        private static void Concerts(RecordLabelContext context, Bands newBand)
        {
            var userTypedName = false;
            while (!userTypedName)
            {
                Console.WriteLine($"\nWhich band's concerts would you like to view?");
                var usersBand = Console.ReadLine();

                var bandExists = context.Bands.Any(band => band.Name == usersBand);
                if (bandExists)
                {
                    newBand = context.Bands.FirstOrDefault(band => band.Name == usersBand);

                    Console.WriteLine($"\n{$"{newBand.Name}'s".Pastel(Color.Yellow)} Concerts:\n");
                    foreach (var concert in context.Concerts.Include(concerts => concerts.Band).Where(concerts => concerts.Band == newBand).OrderBy(concerts => concerts.Date))
                    {
                        Console.WriteLine($"{newBand.Name} has a concert on {concert.Date.ToLongDateString()}");
                    }
                    break;
                }
                else
                {
                    Console.WriteLine($"\n{"Your answer was invalid. Please try again!".Pastel(Color.Red)}");
                    Console.WriteLine($"{"You must select a band!".Pastel(Color.Red)}");
                }
            }
        }

        static void Main(string[] args)
        {
            var newBand = new Bands();
            var newAlbum = new Albums();
            var newSong = new Songs();
            var newMusician = new Musicians();
            var newConcert = new Concerts();
            var context = new RecordLabelContext();

            string name = WelcomeUser();

            bool keepGoing, mangagerView;

            MainMenu(newBand, context, name, out keepGoing, out mangagerView);
            ManagerMenu(newBand, newAlbum, newSong, newMusician, newConcert, context, name, ref keepGoing, ref mangagerView);
        }
    }
}


