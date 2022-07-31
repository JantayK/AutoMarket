using AutoMarket.DAL.Models;
using AutoMarket.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoMarket.DAL.Data
{
    public static class DbInitializer
    {
        public static void Seed(this ApplicationDbContext context)
        {
            if (!context.Brands.Any())
            {
                context.Brands.AddRange(
                    new Brand()
                    {
                        Name = "Mercedes-Benz",

                    },
                    new Brand()
                    {
                        Name = "Toyota"
                    },
                    new Brand()
                    {
                        Name = "Lexus"
                    },
                    new Brand()
                    {
                        Name = "BMW"
                    });

            }
            if (!context.Models.Any())
            {
                context.Models.AddRange(
                    new Model()
                    {
                        Name = "E-Klass",
                        BrandId = context.Brands.FirstOrDefault(b => b.Name == "Mercedes-Benz").Id
                    },
                    new Model()
                    {
                        Name = "C-Klass",
                        BrandId = context.Brands.FirstOrDefault(b => b.Name == "Mercedes-Benz").Id
                    },
                    new Model()
                    {
                        Name = "S-Klass",
                        BrandId = context.Brands.FirstOrDefault(b => b.Name == "Mercedes-Benz").Id
                    },
                    new Model()
                    {
                        Name = "ES",
                        BrandId = context.Brands.FirstOrDefault(b => b.Name == "Lexus").Id
                    },
                    new Model()
                    {
                        Name = "RX",
                        BrandId = context.Brands.FirstOrDefault(b => b.Name == "Lexus").Id
                    },
                    new Model()
                    {
                        Name = "LX",
                        BrandId = context.Brands.FirstOrDefault(b => b.Name == "Lexus").Id
                    },
                    new Model()
                    {
                        Name = "5-Series",
                        BrandId = context.Brands.FirstOrDefault(b => b.Name == "BMW").Id
                    },
                    new Model()
                    {
                        Name = "X5",
                        BrandId = context.Brands.FirstOrDefault(b => b.Name == "BMW").Id
                    },
                    new Model()
                    {
                        Name = "X7",
                        BrandId = context.Brands.FirstOrDefault(b => b.Name == "BMW").Id
                    },
                    new Model()
                    {
                        Name = "Camry",
                        BrandId = context.Brands.FirstOrDefault(b => b.Name == "Toyota").Id
                    },
                    new Model()
                    {
                        Name = "Land Cruiser",
                        BrandId = context.Brands.FirstOrDefault(b => b.Name == "Toyota").Id
                    },
                    new Model()
                    {
                        Name = "Ist",
                        BrandId = context.Brands.FirstOrDefault(b => b.Name == "Toyota").Id
                    });
            }
            if (!context.Generations.Any())
            {
                context.Generations.AddRange(
                    new Generation()
                    {
                        BodyName = "W124",
                        StartYear = 1992,
                        EndYear = 1997,
                        GenerationNumber = 1,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "E-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W210, S210",
                        StartYear = 1995,
                        EndYear = 1999,
                        GenerationNumber = 2,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "E-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W210, S210",
                        StartYear = 1999,
                        EndYear = 2003,
                        GenerationNumber = 2,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "E-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W211, S211",
                        StartYear = 2002,
                        EndYear = 2006,
                        GenerationNumber = 3,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "E-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W211, S211",
                        StartYear = 2006,
                        EndYear = 2009,
                        GenerationNumber = 3,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "E-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W212, S212, C207",
                        StartYear = 2009,
                        EndYear = 2013,
                        GenerationNumber = 4,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "E-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W212, S212, C207",
                        StartYear = 2013,
                        EndYear = 2016,
                        GenerationNumber = 4,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "E-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W213, S213, C238",
                        StartYear = 2016,
                        EndYear = 2021,
                        GenerationNumber = 5,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "E-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W213, S213, C238",
                        StartYear = 2020,
                        EndYear = 2022,
                        GenerationNumber = 5,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "E-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W202",
                        StartYear = 1993,
                        EndYear = 1997,
                        GenerationNumber = 1,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "C-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W202",
                        StartYear = 1997,
                        EndYear = 2001,
                        GenerationNumber = 1,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "C-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W203",
                        StartYear = 2000,
                        EndYear = 2004,
                        GenerationNumber = 2,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "C-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W203",
                        StartYear = 2004,
                        EndYear = 2008,
                        GenerationNumber = 2,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "C-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W204",
                        StartYear = 2006,
                        EndYear = 2011,
                        GenerationNumber = 3,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "C-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W204",
                        StartYear = 2011,
                        EndYear = 2015,
                        GenerationNumber = 3,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "C-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W205",
                        StartYear = 2014,
                        EndYear = 2018,
                        GenerationNumber = 4,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "C-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W205",
                        StartYear = 2018,
                        EndYear = 2021,
                        GenerationNumber = 4,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "C-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W206",
                        StartYear = 2021,
                        EndYear = 2022,
                        GenerationNumber = 4,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "C-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W108",
                        StartYear = 1965,
                        EndYear = 1972,
                        GenerationNumber = 0,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "S-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W116",
                        StartYear = 1972,
                        EndYear = 1980,
                        GenerationNumber = 1,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "S-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W126",
                        StartYear = 1979,
                        EndYear = 1985,
                        GenerationNumber = 2,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "S-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W126",
                        StartYear = 1985,
                        EndYear = 1991,
                        GenerationNumber = 2,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "S-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W140",
                        StartYear = 1991,
                        EndYear = 1998,
                        GenerationNumber = 3,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "S-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W140",
                        StartYear = 1994,
                        EndYear = 1999,
                        GenerationNumber = 3,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "S-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W220",
                        StartYear = 1998,
                        EndYear = 2005,
                        GenerationNumber = 4,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "S-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W220",
                        StartYear = 2002,
                        EndYear = 2005,
                        GenerationNumber = 4,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "S-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W221",
                        StartYear = 2005,
                        EndYear = 2009,
                        GenerationNumber = 5,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "S-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W221",
                        StartYear = 2009,
                        EndYear = 2013,
                        GenerationNumber = 5,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "S-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W222, C217",
                        StartYear = 2013,
                        EndYear = 2017,
                        GenerationNumber = 6,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "S-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W222, C217",
                        StartYear = 2017,
                        EndYear = 2020,
                        GenerationNumber = 6,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "S-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "W223",
                        StartYear = 2020,
                        EndYear = 2022,
                        GenerationNumber = 7,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "S-Klass").Id
                    },
                    new Generation()
                    {
                        BodyName = "1es",
                        StartYear = 1991,
                        EndYear = 1994,
                        GenerationNumber = 2,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "ES").Id
                    },
                    new Generation()
                    {
                        BodyName = "1es",
                        StartYear = 1994,
                        EndYear = 1996,
                        GenerationNumber = 2,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "ES").Id
                    },
                    new Generation()
                    {
                        BodyName = "1es",
                        StartYear = 1996,
                        EndYear = 2001,
                        GenerationNumber = 3,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "ES").Id
                    },
                    new Generation()
                    {
                        BodyName = "2es",
                        StartYear = 2001,
                        EndYear = 2003,
                        GenerationNumber = 4,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "ES").Id
                    },
                    new Generation()
                    {
                        BodyName = "2es",
                        StartYear = 2003,
                        EndYear = 2006,
                        GenerationNumber = 4,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "ES").Id
                    },
                    new Generation()
                    {
                        BodyName = "3es",
                        StartYear = 2006,
                        EndYear = 2009,
                        GenerationNumber = 5,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "ES").Id
                    },
                    new Generation()
                    {
                        BodyName = "3es",
                        StartYear = 2009,
                        EndYear = 2012,
                        GenerationNumber = 5,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "ES").Id
                    },
                    new Generation()
                    {
                        BodyName = "4es",
                        StartYear = 2012,
                        EndYear = 2015,
                        GenerationNumber = 6,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "ES").Id
                    },
                    new Generation()
                    {
                        BodyName = "4es",
                        StartYear = 2015,
                        EndYear = 2018,
                        GenerationNumber = 6,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "ES").Id
                    },
                    new Generation()
                    {
                        BodyName = "5es",
                        StartYear = 2018,
                        EndYear = 2021,
                        GenerationNumber = 7,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "ES").Id
                    },
                    new Generation()
                    {
                        BodyName = "5es",
                        StartYear = 2021,
                        EndYear = 2022,
                        GenerationNumber = 7,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "ES").Id
                    },
                    new Generation()
                    {
                        BodyName = "1rx",
                        StartYear = 1997,
                        EndYear = 2003,
                        GenerationNumber = 1,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "RX").Id
                    },
                    new Generation()
                    {
                        BodyName = "2rx",
                        StartYear = 2003,
                        EndYear = 2006,
                        GenerationNumber = 2,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "RX").Id
                    },
                    new Generation()
                    {
                        BodyName = "2rx",
                        StartYear = 2006,
                        EndYear = 2009,
                        GenerationNumber = 2,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "RX").Id
                    },
                    new Generation()
                    {
                        BodyName = "3rx",
                        StartYear = 2008,
                        EndYear = 2012,
                        GenerationNumber = 3,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "RX").Id
                    },
                    new Generation()
                    {
                        BodyName = "3rx",
                        StartYear = 2012,
                        EndYear = 2015,
                        GenerationNumber = 3,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "RX").Id
                    },
                    new Generation()
                    {
                        BodyName = "4rx",
                        StartYear = 2015,
                        EndYear = 2019,
                        GenerationNumber = 4,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "RX").Id
                    },
                    new Generation()
                    {
                        BodyName = "4rx",
                        StartYear = 2019,
                        EndYear = 2022,
                        GenerationNumber = 4,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "RX").Id
                    },
                    new Generation()
                    {
                        BodyName = "1lx",
                        StartYear = 1995,
                        EndYear = 1997,
                        GenerationNumber = 1,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "LX").Id
                    },
                    new Generation()
                    {
                        BodyName = "2lx",
                        StartYear = 1998,
                        EndYear = 2002,
                        GenerationNumber = 2,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "LX").Id
                    },
                    new Generation()
                    {
                        BodyName = "2lx",
                        StartYear = 2002,
                        EndYear = 2007,
                        GenerationNumber = 2,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "LX").Id
                    },
                    new Generation()
                    {
                        BodyName = "3lx",
                        StartYear = 2007,
                        EndYear = 2012,
                        GenerationNumber = 3,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "LX").Id
                    },
                    new Generation()
                    {
                        BodyName = "3lx",
                        StartYear = 2012,
                        EndYear = 2015,
                        GenerationNumber = 3,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "LX").Id
                    },
                    new Generation()
                    {
                        BodyName = "3lx",
                        StartYear = 2015,
                        EndYear = 2022,
                        GenerationNumber = 3,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "LX").Id
                    },
                    new Generation()
                    {
                        BodyName = "4lx",
                        StartYear = 2021,
                        EndYear = 2022,
                        GenerationNumber = 4,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "LX").Id
                    },
                    new Generation()
                    {
                        BodyName = "XV20",
                        StartYear = 1996,
                        EndYear = 2000,
                        GenerationNumber = 1,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Camry").Id
                    },
                    new Generation()
                    {
                        BodyName = "XV20",
                        StartYear = 1999,
                        EndYear = 2002,
                        GenerationNumber = 1,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Camry").Id
                    },
                    new Generation()
                    {
                        BodyName = "XV30",
                        StartYear = 2001,
                        EndYear = 2004,
                        GenerationNumber = 2,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Camry").Id
                    },
                    new Generation()
                    {
                        BodyName = "XV30",
                        StartYear = 2004,
                        EndYear = 2006,
                        GenerationNumber = 2,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Camry").Id
                    },
                    new Generation()
                    {
                        BodyName = "XV40",
                        StartYear = 2006,
                        EndYear = 2009,
                        GenerationNumber = 3,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Camry").Id
                    },
                    new Generation()
                    {
                        BodyName = "XV40",
                        StartYear = 2009,
                        EndYear = 2011,
                        GenerationNumber = 3,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Camry").Id
                    },
                    new Generation()
                    {
                        BodyName = "XV50",
                        StartYear = 2011,
                        EndYear = 2014,
                        GenerationNumber = 4,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Camry").Id
                    },
                    new Generation()
                    {
                        BodyName = "XV50",
                        StartYear = 2014,
                        EndYear = 2017,
                        GenerationNumber = 4,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Camry").Id
                    },
                    new Generation()
                    {
                        BodyName = "XV50",
                        StartYear = 2017,
                        EndYear = 2018,
                        GenerationNumber = 4,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Camry").Id
                    },
                    new Generation()
                    {
                        BodyName = "XV70",
                        StartYear = 2018,
                        EndYear = 2021,
                        GenerationNumber = 5,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Camry").Id
                    },
                    new Generation()
                    {
                        BodyName = "XV70",
                        StartYear = 2020,
                        EndYear = 2022,
                        GenerationNumber = 5,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Camry").Id
                    },
                    new Generation()
                    {
                        BodyName = "XV70",
                        StartYear = 2020,
                        EndYear = 2022,
                        GenerationNumber = 5,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Camry").Id
                    },
                    new Generation()
                    {
                        BodyName = "100 Series",
                        StartYear = 1998,
                        EndYear = 2002,
                        GenerationNumber = 5,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Land Cruiser").Id
                    },
                    new Generation()
                    {
                        BodyName = "100 Series",
                        StartYear = 2002,
                        EndYear = 2005,
                        GenerationNumber = 5,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Land Cruiser").Id
                    },
                    new Generation()
                    {
                        BodyName = "100 Series",
                        StartYear = 2005,
                        EndYear = 2007,
                        GenerationNumber = 5,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Land Cruiser").Id
                    },
                    new Generation()
                    {
                        BodyName = "200 Series",
                        StartYear = 2007,
                        EndYear = 2012,
                        GenerationNumber = 6,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Land Cruiser").Id
                    },
                    new Generation()
                    {
                        BodyName = "200 Series",
                        StartYear = 2012,
                        EndYear = 2015,
                        GenerationNumber = 6,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Land Cruiser").Id
                    },
                    new Generation()
                    {
                        BodyName = "200 Series",
                        StartYear = 2015,
                        EndYear = 2021,
                        GenerationNumber = 6,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Land Cruiser").Id
                    },
                    new Generation()
                    {
                        BodyName = "300 Series",
                        StartYear = 2015,
                        EndYear = 2021,
                        GenerationNumber = 6,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Land Cruiser").Id
                    },
                    new Generation()
                    {
                        BodyName = "ist1",
                        StartYear = 2001,
                        EndYear = 2005,
                        GenerationNumber = 1,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Ist").Id
                    },
                    new Generation()
                    {
                        BodyName = "ist1",
                        StartYear = 2005,
                        EndYear = 2007,
                        GenerationNumber = 1,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Ist").Id
                    },
                    new Generation()
                    {
                        BodyName = "ist2",
                        StartYear = 2007,
                        EndYear = 2016,
                        GenerationNumber = 2,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "Ist").Id
                    },
                    new Generation()
                    {
                        BodyName = "E34",
                        StartYear = 1987,
                        EndYear = 1996,
                        GenerationNumber = 1,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "5-Series").Id
                    },
                    new Generation()
                    {
                        BodyName = "E39",
                        StartYear = 1995,
                        EndYear = 2000,
                        GenerationNumber = 2,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "5-Series").Id
                    },
                    new Generation()
                    {
                        BodyName = "E39",
                        StartYear = 2000,
                        EndYear = 2004,
                        GenerationNumber = 2,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "5-Series").Id
                    },
                    new Generation()
                    {
                        BodyName = "E60/61",
                        StartYear = 2003,
                        EndYear = 2007,
                        GenerationNumber = 3,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "5-Series").Id
                    },
                    new Generation()
                    {
                        BodyName = "E60/61",
                        StartYear = 2007,
                        EndYear = 2010,
                        GenerationNumber = 3,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "5-Series").Id
                    },
                    new Generation()
                    {
                        BodyName = "F10/F11/F07",
                        StartYear = 2009,
                        EndYear = 2013,
                        GenerationNumber = 4,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "5-Series").Id
                    },
                    new Generation()
                    {
                        BodyName = "F10/F11/F07",
                        StartYear = 2013,
                        EndYear = 2017,
                        GenerationNumber = 4,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "5-Series").Id
                    },
                    new Generation()
                    {
                        BodyName = "G30/G31",
                        StartYear = 2017,
                        EndYear = 2020,
                        GenerationNumber = 5,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "5-Series").Id
                    },
                    new Generation()
                    {
                        BodyName = "G30/G31",
                        StartYear = 2020,
                        EndYear = 2022,
                        GenerationNumber = 5,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "5-Series").Id
                    },
                    new Generation()
                    {
                        BodyName = "E53",
                        StartYear = 1999,
                        EndYear = 2003,
                        GenerationNumber = 1,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "X5").Id
                    },
                    new Generation()
                    {
                        BodyName = "E53",
                        StartYear = 2003,
                        EndYear = 2006,
                        GenerationNumber = 1,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "X5").Id
                    },
                    new Generation()
                    {
                        BodyName = "E70",
                        StartYear = 2006,
                        EndYear = 2010,
                        GenerationNumber = 2,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "X5").Id
                    },
                    new Generation()
                    {
                        BodyName = "E70",
                        StartYear = 2010,
                        EndYear = 2013,
                        GenerationNumber = 2,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "X5").Id
                    },
                    new Generation()
                    {
                        BodyName = "F15",
                        StartYear = 2013,
                        EndYear = 2018,
                        GenerationNumber = 3,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "X5").Id
                    },
                    new Generation()
                    {
                        BodyName = "G05",
                        StartYear = 2018,
                        EndYear = 2022,
                        GenerationNumber = 4,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "X5").Id
                    },
                    new Generation()
                    {
                        BodyName = "G07",
                        StartYear = 2019,
                        EndYear = 2022,
                        GenerationNumber = 1,
                        Restyling = false,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "X7").Id
                    },
                    new Generation()
                    {
                        BodyName = "G07",
                        StartYear = 2022,
                        EndYear = 2022,
                        GenerationNumber = 1,
                        Restyling = true,
                        ModelId = context.Models.FirstOrDefault(b => b.Name == "X7").Id
                    });
            }
            if (!context.CarCharacteristics.Any())
            {
                context.CarCharacteristics.AddRange(
                    new CarCharacteristics()
                    {
                        AccelerationTime = 12.1,
                        AverageFuelConsumption = 9.2,
                        Clearance = 160,
                        Cylinders = 4,
                        EnginePower = 136,
                        EngineVolume = 1998,
                        FuelTankCapacity = 72,
                        Height = 1490,
                        Length = 4765,
                        MaxSpeed = 188,
                        Torque = 190,
                        Weight = 1470,
                        Width = 1740,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W124").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.6,
                        AverageFuelConsumption = 10.2,
                        Clearance = 160,
                        Cylinders = 4,
                        EngineVolume = 2199,
                        EnginePower = 150,
                        FuelTankCapacity = 72,
                        Height = 1490,
                        Length = 4740,
                        MaxSpeed = 210,
                        Torque = 210,
                        Weight = 1460,
                        Width = 1740,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W124").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.7,
                        AverageFuelConsumption = 10.4,
                        Clearance = 135,
                        Cylinders = 6,
                        EngineVolume = 2799,
                        EnginePower = 193,
                        FuelTankCapacity = 70,
                        Height = 1430,
                        Length = 4740,
                        MaxSpeed = 225,
                        Torque = 270,
                        Weight = 1460,
                        Width = 1740,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W124").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 12.8,
                        AverageFuelConsumption = 5.5,
                        Clearance = 160,
                        Cylinders = 6,
                        EngineVolume = 2996,
                        EnginePower = 136,
                        FuelTankCapacity = 70,
                        Height = 1430,
                        Length = 4740,
                        MaxSpeed = 225,
                        Torque = 210,
                        Weight = 1560,
                        Width = 1740,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W124").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.9,
                        AverageFuelConsumption = 11.2,
                        Clearance = 135,
                        Cylinders = 6,
                        EngineVolume = 3199,
                        EnginePower = 220,
                        FuelTankCapacity = 70,
                        Height = 1430,
                        Length = 4740,
                        MaxSpeed = 230,
                        Torque = 315,
                        Weight = 1560,
                        Width = 1740,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W124").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.1,
                        AverageFuelConsumption = 16.9,
                        Clearance = 150,
                        Cylinders = 8,
                        EngineVolume = 4973,
                        EnginePower = 320,
                        FuelTankCapacity = 70,
                        Height = 1430,
                        Length = 4740,
                        MaxSpeed = 250,
                        Torque = 470,
                        Weight = 1800,
                        Width = 1740,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W124").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 15.5,
                        AverageFuelConsumption = 7.1,
                        Clearance = 135,
                        Cylinders = 5,
                        EngineVolume = 2497,
                        EnginePower = 113,
                        FuelTankCapacity = 70,
                        Height = 1430,
                        Length = 4740,
                        MaxSpeed = 190,
                        Torque = 173,
                        Weight = 1560,
                        Width = 1740,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W124").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.2,
                        AverageFuelConsumption = 9.4,
                        Clearance = 160,
                        Cylinders = 8,
                        EngineVolume = 4196,
                        EnginePower = 279,
                        FuelTankCapacity = 70,
                        Height = 1430,
                        Length = 4740,
                        MaxSpeed = 190,
                        Torque = 400,
                        Weight = 1720,
                        Width = 1740,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W124").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 12.8,
                        AverageFuelConsumption = 7.5,
                        Clearance = 160,
                        Cylinders = 4,
                        EngineVolume = 1998,
                        EnginePower = 136,
                        FuelTankCapacity = 65,
                        Height = 1420,
                        Length = 4796,
                        MaxSpeed = 202,
                        Torque = 190,
                        Weight = 1425,
                        Width = 1798,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W210, S210").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.7,
                        AverageFuelConsumption = 10.3,
                        Clearance = 160,
                        Cylinders = 6,
                        EngineVolume = 2397,
                        EnginePower = 170,
                        FuelTankCapacity = 65,
                        Height = 1420,
                        Length = 4796,
                        MaxSpeed = 220,
                        Torque = 225,
                        Weight = 1425,
                        Width = 1798,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W210, S210").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.7,
                        AverageFuelConsumption = 10.3,
                        Clearance = 160,
                        Cylinders = 6,
                        EngineVolume = 3199,
                        EnginePower = 224,
                        FuelTankCapacity = 65,
                        Height = 1420,
                        Length = 4796,
                        MaxSpeed = 238,
                        Torque = 315,
                        Weight = 1505,
                        Width = 1798,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W210, S210").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.6,
                        AverageFuelConsumption = 11.3,
                        Clearance = 142,
                        Cylinders = 8,
                        EngineVolume = 4266,
                        EnginePower = 279,
                        FuelTankCapacity = 65,
                        Height = 1420,
                        Length = 4796,
                        MaxSpeed = 250,
                        Torque = 400,
                        Weight = 1575,
                        Width = 1798,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W210, S210").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.6,
                        AverageFuelConsumption = 11.3,
                        Clearance = 142,
                        Cylinders = 8,
                        EngineVolume = 4266,
                        EnginePower = 279,
                        FuelTankCapacity = 65,
                        Height = 1420,
                        Length = 4796,
                        MaxSpeed = 250,
                        Torque = 400,
                        Weight = 1575,
                        Width = 1798,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W210, S210").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.9,
                        AverageFuelConsumption = 9.7,
                        Clearance = 160,
                        Cylinders = 6,
                        EngineVolume = 3498,
                        EnginePower = 272,
                        FuelTankCapacity = 65,
                        Height = 1483,
                        Length = 4852,
                        MaxSpeed = 250,
                        Torque = 350,
                        Weight = 1620,
                        Width = 1822,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W211, S211").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.7,
                        AverageFuelConsumption = 6.5,
                        Clearance = 160,
                        Cylinders = 4,
                        EngineVolume = 1796,
                        EnginePower = 163,
                        FuelTankCapacity = 65,
                        Height = 1483,
                        Length = 4852,
                        MaxSpeed = 227,
                        Torque = 230,
                        Weight = 1510,
                        Width = 1822,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W211, S211").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.2,
                        AverageFuelConsumption = 6.7,
                        Clearance = 160,
                        Cylinders = 4,
                        EngineVolume = 2148,
                        EnginePower = 150,
                        FuelTankCapacity = 65,
                        Height = 1483,
                        Length = 4852,
                        MaxSpeed = 218,
                        Torque = 340,
                        Weight = 1510,
                        Width = 1822,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W211, S211").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.8,
                        AverageFuelConsumption = 7.6,
                        Clearance = 160,
                        Cylinders = 6,
                        EngineVolume = 2987,
                        EnginePower = 224,
                        FuelTankCapacity = 65,
                        Height = 1483,
                        Length = 4852,
                        MaxSpeed = 250,
                        Torque = 540,
                        Weight = 1680,
                        Width = 1822,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W211, S211").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5.5,
                        AverageFuelConsumption = 12,
                        Clearance = 160,
                        Cylinders = 8,
                        EngineVolume = 5461,
                        EnginePower = 388,
                        FuelTankCapacity = 65,
                        Height = 1483,
                        Length = 4852,
                        MaxSpeed = 250,
                        Torque = 530,
                        Weight = 1810,
                        Width = 1822,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W211, S211").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.7,
                        AverageFuelConsumption = 6.9,
                        Clearance = 160,
                        Cylinders = 6,
                        EngineVolume = 3222,
                        EnginePower = 204,
                        FuelTankCapacity = 65,
                        Height = 1483,
                        Length = 4852,
                        MaxSpeed = 243,
                        Torque = 500,
                        Weight = 1735,
                        Width = 1822,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W211, S211").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.4,
                        AverageFuelConsumption = 4.6,
                        Clearance = 150,
                        Cylinders = 4,
                        EngineVolume = 2143,
                        EnginePower = 170,
                        FuelTankCapacity = 59,
                        Height = 1474,
                        Length = 4879,
                        MaxSpeed = 227,
                        Torque = 400,
                        Weight = 1854,
                        Width = 1822,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W212, S212, C207").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.9,
                        AverageFuelConsumption = 6.1,
                        Clearance = 150,
                        Cylinders = 4,
                        EngineVolume = 1991,
                        EnginePower = 184,
                        FuelTankCapacity = 59,
                        Height = 1474,
                        Length = 4879,
                        MaxSpeed = 233,
                        Torque = 270,
                        Weight = 1655,
                        Width = 1822,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W212, S212, C207").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.1,
                        AverageFuelConsumption = 7,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 3498,
                        EnginePower = 252,
                        FuelTankCapacity = 59,
                        Height = 1474,
                        Length = 4879,
                        MaxSpeed = 250,
                        Torque = 340,
                        Weight = 1735,
                        Width = 1822,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W212, S212, C207").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.8,
                        AverageFuelConsumption = 6.9,
                        Clearance = 160,
                        Cylinders = 4,
                        EngineVolume = 1796,
                        EnginePower = 184,
                        FuelTankCapacity = 66,
                        Height = 1397,
                        Length = 4698,
                        MaxSpeed = 237,
                        Torque = 270,
                        Weight = 1735,
                        Width = 1822,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W212, S212, C207").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5.2,
                        AverageFuelConsumption = 10.9,
                        Clearance = 160,
                        Cylinders = 8,
                        EngineVolume = 5461,
                        EnginePower = 388,
                        FuelTankCapacity = 80,
                        Height = 1471,
                        Length = 4698,
                        MaxSpeed = 250,
                        Torque = 530,
                        Weight = 1830,
                        Width = 1854,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W212, S212, C207").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.7,
                        AverageFuelConsumption = 6.3,
                        Clearance = 135,
                        Cylinders = 4,
                        EngineVolume = 1991,
                        EnginePower = 184,
                        FuelTankCapacity = 80,
                        Height = 1468,
                        Length = 4923,
                        MaxSpeed = 240,
                        Torque = 300,
                        Weight = 1605,
                        Width = 1852,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W213, S213, C238").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5.2,
                        AverageFuelConsumption = 7.9,
                        Clearance = 135,
                        Cylinders = 6,
                        EngineVolume = 3498,
                        EnginePower = 333,
                        FuelTankCapacity = 66,
                        Height = 1468,
                        Length = 4923,
                        MaxSpeed = 250,
                        Torque = 480,
                        Weight = 1820,
                        Width = 1852,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W213, S213, C238").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 11.9,
                        AverageFuelConsumption = 9.4,
                        Clearance = 150,
                        Cylinders = 4,
                        EngineVolume = 1799,
                        EnginePower = 122,
                        FuelTankCapacity = 62,
                        Height = 1415,
                        Length = 4487,
                        MaxSpeed = 190,
                        Torque = 170,
                        Weight = 1350,
                        Width = 1720,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W202").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 11,
                        AverageFuelConsumption = 8.7,
                        Clearance = 150,
                        Cylinders = 4,
                        EngineVolume = 1998,
                        EnginePower = 136,
                        FuelTankCapacity = 62,
                        Height = 1415,
                        Length = 4487,
                        MaxSpeed = 198,
                        Torque = 190,
                        Weight = 1365,
                        Width = 1720,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W202").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.4,
                        AverageFuelConsumption = 8.7,
                        Clearance = 150,
                        Cylinders = 4,
                        EngineVolume = 1998,
                        EnginePower = 150,
                        FuelTankCapacity = 62,
                        Height = 1415,
                        Length = 4487,
                        MaxSpeed = 210,
                        Torque = 210,
                        Weight = 1365,
                        Width = 1720,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W202").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.4,
                        AverageFuelConsumption = 8.7,
                        Clearance = 150,
                        Cylinders = 4,
                        EngineVolume = 1998,
                        EnginePower = 197,
                        FuelTankCapacity = 62,
                        Height = 1415,
                        Length = 4487,
                        MaxSpeed = 230,
                        Torque = 280,
                        Weight = 1420,
                        Width = 1720,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W202").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.4,
                        AverageFuelConsumption = 8.3,
                        Clearance = 150,
                        Cylinders = 4,
                        EngineVolume = 2297,
                        EnginePower = 197,
                        FuelTankCapacity = 62,
                        Height = 1415,
                        Length = 4487,
                        MaxSpeed = 230,
                        Torque = 280,
                        Weight = 1420,
                        Width = 1720,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W202").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.8,
                        AverageFuelConsumption = 10.6,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 2799,
                        EnginePower = 193,
                        FuelTankCapacity = 62,
                        Height = 1415,
                        Length = 4487,
                        MaxSpeed = 230,
                        Torque = 270,
                        Weight = 1420,
                        Width = 1720,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W202").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9.9,
                        AverageFuelConsumption = 10.7,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 2597,
                        EnginePower = 170,
                        FuelTankCapacity = 62,
                        Height = 1415,
                        Length = 4487,
                        MaxSpeed = 214,
                        Torque = 240,
                        Weight = 1420,
                        Width = 1720,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W202").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9.4,
                        AverageFuelConsumption = 8.3,
                        Clearance = 150,
                        Cylinders = 4,
                        EngineVolume = 1769,
                        EnginePower = 163,
                        FuelTankCapacity = 62,
                        Height = 1427,
                        Length = 4526,
                        MaxSpeed = 231,
                        Torque = 240,
                        Weight = 1435,
                        Width = 1728,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W203").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.9,
                        AverageFuelConsumption = 9.3,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 2496,
                        EnginePower = 204,
                        FuelTankCapacity = 62,
                        Height = 1427,
                        Length = 4526,
                        MaxSpeed = 238,
                        Torque = 245,
                        Weight = 1435,
                        Width = 1728,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W203").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9.5,
                        AverageFuelConsumption = 10.1,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 2597,
                        EnginePower = 170,
                        FuelTankCapacity = 62,
                        Height = 1427,
                        Length = 4526,
                        MaxSpeed = 232,
                        Torque = 240,
                        Weight = 1435,
                        Width = 1728,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W203").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.3,
                        AverageFuelConsumption = 9.4,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 2996,
                        EnginePower = 231,
                        FuelTankCapacity = 62,
                        Height = 1427,
                        Length = 4526,
                        MaxSpeed = 250,
                        Torque = 300,
                        Weight = 1435,
                        Width = 1728,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W203").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.8,
                        AverageFuelConsumption = 10.2,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 3199,
                        EnginePower = 218,
                        FuelTankCapacity = 62,
                        Height = 1427,
                        Length = 4526,
                        MaxSpeed = 245,
                        Torque = 310,
                        Weight = 1435,
                        Width = 1728,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W203").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.9,
                        AverageFuelConsumption = 10.3,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 3498,
                        EnginePower = 272,
                        FuelTankCapacity = 62,
                        Height = 1427,
                        Length = 4526,
                        MaxSpeed = 250,
                        Torque = 350,
                        Weight = 1585,
                        Width = 1728,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W203").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.9,
                        AverageFuelConsumption = 10.3,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 3498,
                        EnginePower = 272,
                        FuelTankCapacity = 62,
                        Height = 1427,
                        Length = 4526,
                        MaxSpeed = 250,
                        Torque = 350,
                        Weight = 1585,
                        Width = 1728,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W203").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.8,
                        AverageFuelConsumption = 6.9,
                        Clearance = 150,
                        Cylinders = 4,
                        EngineVolume = 1796,
                        EnginePower = 184,
                        FuelTankCapacity = 67,
                        Height = 1447,
                        Length = 4591,
                        MaxSpeed = 235,
                        Torque = 270,
                        Weight = 1505,
                        Width = 1770,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W204").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.6,
                        AverageFuelConsumption = 9.3,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 2496,
                        EnginePower = 204,
                        FuelTankCapacity = 66,
                        Height = 1447,
                        Length = 4581,
                        MaxSpeed = 233,
                        Torque = 245,
                        Weight = 1540,
                        Width = 1770,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W204").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.2,
                        AverageFuelConsumption = 9.6,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 2996,
                        EnginePower = 231,
                        FuelTankCapacity = 66,
                        Height = 1447,
                        Length = 4581,
                        MaxSpeed = 246,
                        Torque = 300,
                        Weight = 1555,
                        Width = 1770,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W204").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.5,
                        AverageFuelConsumption = 5.8,
                        Clearance = 140,
                        Cylinders = 4,
                        EngineVolume = 1595,
                        EnginePower = 156,
                        FuelTankCapacity = 41,
                        Height = 1442,
                        Length = 4686,
                        MaxSpeed = 223,
                        Torque = 250,
                        Weight = 1425,
                        Width = 1810,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W205").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.8,
                        AverageFuelConsumption = 4.5,
                        Clearance = 140,
                        Cylinders = 4,
                        EngineVolume = 2143,
                        EnginePower = 170,
                        FuelTankCapacity = 41,
                        Height = 1442,
                        Length = 4686,
                        MaxSpeed = 233,
                        Torque = 400,
                        Weight = 1425,
                        Width = 1810,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W205").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.9,
                        AverageFuelConsumption = 4.9,
                        Clearance = 140,
                        Cylinders = 4,
                        EngineVolume = 1950,
                        EnginePower = 194,
                        FuelTankCapacity = 41,
                        Height = 1442,
                        Length = 4686,
                        MaxSpeed = 233,
                        Torque = 400,
                        Weight = 1665,
                        Width = 1810,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W205").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 4.9,
                        AverageFuelConsumption = 7.8,
                        Clearance = 140,
                        Cylinders = 6,
                        EngineVolume = 2996,
                        EnginePower = 333,
                        FuelTankCapacity = 41,
                        Height = 1442,
                        Length = 4686,
                        MaxSpeed = 250,
                        Torque = 480,
                        Weight = 1665,
                        Width = 1810,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W205").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 4.9,
                        AverageFuelConsumption = 7.8,
                        Clearance = 130,
                        Cylinders = 4,
                        EngineVolume = 1496,
                        EnginePower = 170,
                        FuelTankCapacity = 40,
                        Height = 1438,
                        Length = 4751,
                        MaxSpeed = 231,
                        Torque = 250,
                        Weight = 1710,
                        Width = 1820,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W206").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.5,
                        AverageFuelConsumption = 14.7,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 2778,
                        EnginePower = 160,
                        FuelTankCapacity = 0,
                        Height = 1440,
                        Length = 4900,
                        MaxSpeed = 231,
                        Torque = 240,
                        Weight = 0,
                        Width = 1810,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W108").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10,
                        AverageFuelConsumption = 14.7,
                        Clearance = 150,
                        Cylinders = 8,
                        EngineVolume = 3499,
                        EnginePower = 200,
                        FuelTankCapacity = 0,
                        Height = 1440,
                        Length = 4900,
                        MaxSpeed = 231,
                        Torque = 240,
                        Weight = 0,
                        Width = 1810,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W108").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10,
                        AverageFuelConsumption = 14.7,
                        Clearance = 150,
                        Cylinders = 8,
                        EngineVolume = 3499,
                        EnginePower = 200,
                        FuelTankCapacity = 0,
                        Height = 1440,
                        Length = 4900,
                        MaxSpeed = 231,
                        Torque = 240,
                        Weight = 0,
                        Width = 1810,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W108").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.3,
                        AverageFuelConsumption = 14.7,
                        Clearance = 160,
                        Cylinders = 8,
                        EngineVolume = 3500,
                        EnginePower = 205,
                        FuelTankCapacity = 0,
                        Height = 1430,
                        Length = 4960,
                        MaxSpeed = 200,
                        Torque = 240,
                        Weight = 1675,
                        Width = 1870,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W116").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.4,
                        AverageFuelConsumption = 20.1,
                        Clearance = 160,
                        Cylinders = 8,
                        EngineVolume = 6814,
                        EnginePower = 286,
                        FuelTankCapacity = 96,
                        Height = 1430,
                        Length = 4960,
                        MaxSpeed = 225,
                        Torque = 549,
                        Weight = 1935,
                        Width = 1870,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W116").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.2,
                        AverageFuelConsumption = 16.6,
                        Clearance = 150,
                        Cylinders = 8,
                        EngineVolume = 5547,
                        EnginePower = 279,
                        FuelTankCapacity = 0,
                        Height = 1406,
                        Length = 4910,
                        MaxSpeed = 225,
                        Torque = 430,
                        Weight = 1935,
                        Width = 1870,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W126").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.3,
                        AverageFuelConsumption = 13,
                        Clearance = 150,
                        Cylinders = 8,
                        EngineVolume = 4200,
                        EnginePower = 224,
                        FuelTankCapacity = 0,
                        Height = 1406,
                        Length = 4910,
                        MaxSpeed = 225,
                        Torque = 325,
                        Weight = 1620,
                        Width = 1870,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W126").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9.3,
                        AverageFuelConsumption = 13.4,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 3199,
                        EnginePower = 231,
                        FuelTankCapacity = 100,
                        Height = 1406,
                        Length = 5213,
                        MaxSpeed = 225,
                        Torque = 315,
                        Weight = 1491,
                        Width = 1870,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W126").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.3,
                        AverageFuelConsumption = 14.9,
                        Clearance = 150,
                        Cylinders = 8,
                        EngineVolume = 4196,
                        EnginePower = 279,
                        FuelTankCapacity = 100,
                        Height = 1406,
                        Length = 5213,
                        MaxSpeed = 225,
                        Torque = 400,
                        Weight = 1965,
                        Width = 1887,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W140").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.3,
                        AverageFuelConsumption = 15.9,
                        Clearance = 150,
                        Cylinders = 8,
                        EngineVolume = 4973,
                        EnginePower = 320,
                        FuelTankCapacity = 100,
                        Height = 1406,
                        Length = 5213,
                        MaxSpeed = 250,
                        Torque = 470,
                        Weight = 2010,
                        Width = 1887,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W140").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.6,
                        AverageFuelConsumption = 16.9,
                        Clearance = 150,
                        Cylinders = 12,
                        EngineVolume = 5987,
                        EnginePower = 394,
                        FuelTankCapacity = 100,
                        Height = 1406,
                        Length = 5213,
                        MaxSpeed = 250,
                        Torque = 570,
                        Weight = 2155,
                        Width = 1887,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W140").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.1,
                        AverageFuelConsumption = 11.5,
                        Clearance = 150,
                        Cylinders = 8,
                        EngineVolume = 4266,
                        EnginePower = 279,
                        FuelTankCapacity = 88,
                        Height = 1448,
                        Length = 5042,
                        MaxSpeed = 250,
                        Torque = 400,
                        Weight = 1805,
                        Width = 1855,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W220").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.5,
                        AverageFuelConsumption = 11.9,
                        Clearance = 150,
                        Cylinders = 8,
                        EngineVolume = 4966,
                        EnginePower = 306,
                        FuelTankCapacity = 88,
                        Height = 1448,
                        Length = 5042,
                        MaxSpeed = 250,
                        Torque = 400,
                        Weight = 1805,
                        Width = 1855,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W220").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.2,
                        AverageFuelConsumption = 7.9,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 3222,
                        EnginePower = 204,
                        FuelTankCapacity = 88,
                        Height = 1448,
                        Length = 5042,
                        MaxSpeed = 235,
                        Torque = 500,
                        Weight = 1855,
                        Width = 1855,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W220").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5,
                        AverageFuelConsumption = 9.4,
                        Clearance = 150,
                        Cylinders = 8,
                        EngineVolume = 4663,
                        EnginePower = 435,
                        FuelTankCapacity = 90,
                        Height = 1485,
                        Length = 5226,
                        MaxSpeed = 250,
                        Torque = 700,
                        Weight = 2075,
                        Width = 1871,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W221").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5.4,
                        AverageFuelConsumption = 20.4,
                        Clearance = 150,
                        Cylinders = 12,
                        EngineVolume = 5513,
                        EnginePower = 517,
                        FuelTankCapacity = 90,
                        Height = 1485,
                        Length = 5226,
                        MaxSpeed = 250,
                        Torque = 830,
                        Weight = 3755,
                        Width = 1871,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W221").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5.4,
                        AverageFuelConsumption = 20.4,
                        Clearance = 150,
                        Cylinders = 12,
                        EngineVolume = 5513,
                        EnginePower = 517,
                        FuelTankCapacity = 90,
                        Height = 1485,
                        Length = 5226,
                        MaxSpeed = 260,
                        Torque = 830,
                        Weight = 3755,
                        Width = 1871,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W221").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.1,
                        AverageFuelConsumption = 6.5,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 2987,
                        EnginePower = 258,
                        FuelTankCapacity = 90,
                        Height = 1485,
                        Length = 5226,
                        MaxSpeed = 260,
                        Torque = 620,
                        Weight = 1880,
                        Width = 1871,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W221").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5.2,
                        AverageFuelConsumption = 8.3,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 2996,
                        EnginePower = 367,
                        FuelTankCapacity = 70,
                        Height = 1496,
                        Length = 5271,
                        MaxSpeed = 288,
                        Torque = 540,
                        Weight = 2125,
                        Width = 1905,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W222").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 4.6,
                        AverageFuelConsumption = 8.8,
                        Clearance = 150,
                        Cylinders = 8,
                        EngineVolume = 3982,
                        EnginePower = 469,
                        FuelTankCapacity = 70,
                        Height = 1496,
                        Length = 5271,
                        MaxSpeed = 250,
                        Torque = 700,
                        Weight = 2125,
                        Width = 1905,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W222").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5.8,
                        AverageFuelConsumption = 5.7,
                        Clearance = 130,
                        Cylinders = 6,
                        EngineVolume = 2925,
                        EnginePower = 249,
                        FuelTankCapacity = 70,
                        Height = 1496,
                        Length = 5271,
                        MaxSpeed = 250,
                        Torque = 600,
                        Weight = 2050,
                        Width = 1905,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W222").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5.4,
                        AverageFuelConsumption = 7,
                        Clearance = 130,
                        Cylinders = 6,
                        EngineVolume = 2925,
                        EnginePower = 330,
                        FuelTankCapacity = 65,
                        Height = 1503,
                        Length = 5289,
                        MaxSpeed = 250,
                        Torque = 700,
                        Weight = 2090,
                        Width = 1954,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W223").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 4.4,
                        AverageFuelConsumption = 10.2,
                        Clearance = 130,
                        Cylinders = 8,
                        EngineVolume = 3982,
                        EnginePower = 503,
                        FuelTankCapacity = 76,
                        Height = 1503,
                        Length = 5289,
                        MaxSpeed = 250,
                        Torque = 700,
                        Weight = 2090,
                        Width = 1954,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W223").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 4.9,
                        AverageFuelConsumption = 19.5,
                        Clearance = 130,
                        Cylinders = 12,
                        EngineVolume = 5980,
                        EnginePower = 612,
                        FuelTankCapacity = 76,
                        Height = 1503,
                        Length = 5289,
                        MaxSpeed = 250,
                        Torque = 830,
                        Weight = 4300,
                        Width = 1954,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W223").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 4.9,
                        AverageFuelConsumption = 19.5,
                        Clearance = 130,
                        Cylinders = 12,
                        EngineVolume = 5980,
                        EnginePower = 612,
                        FuelTankCapacity = 76,
                        Height = 1503,
                        Length = 5289,
                        MaxSpeed = 250,
                        Torque = 830,
                        Weight = 4300,
                        Width = 1954,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "W223").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.5,
                        AverageFuelConsumption = 13,
                        Clearance = 190,
                        Cylinders = 6,
                        EngineVolume = 2995,
                        EnginePower = 223,
                        FuelTankCapacity = 75,
                        Height = 1660,
                        Length = 4580,
                        MaxSpeed = 180,
                        Torque = 301,
                        Weight = 1800,
                        Width = 1815,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "20").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.5,
                        AverageFuelConsumption = 13,
                        Clearance = 190,
                        Cylinders = 6,
                        EngineVolume = 2995,
                        EnginePower = 223,
                        FuelTankCapacity = 75,
                        Height = 1660,
                        Length = 4580,
                        MaxSpeed = 180,
                        Torque = 301,
                        Weight = 1800,
                        Width = 1815,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "20").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9,
                        AverageFuelConsumption = 12.2,
                        Clearance = 190,
                        Cylinders = 6,
                        EngineVolume = 2995,
                        EnginePower = 204,
                        FuelTankCapacity = 72,
                        Height = 1675,
                        Length = 4740,
                        MaxSpeed = 180,
                        Torque = 283,
                        Weight = 1880,
                        Width = 1845,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "30").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.3,
                        AverageFuelConsumption = 11.2,
                        Clearance = 190,
                        Cylinders = 6,
                        EngineVolume = 3300,
                        EnginePower = 230,
                        FuelTankCapacity = 72,
                        Height = 1675,
                        Length = 4740,
                        MaxSpeed = 180,
                        Torque = 328,
                        Weight = 1815,
                        Width = 1845,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "30").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.6,
                        AverageFuelConsumption = 8.1,
                        Clearance = 190,
                        Cylinders = 6,
                        EngineVolume = 3311,
                        EnginePower = 211,
                        FuelTankCapacity = 72,
                        Height = 1675,
                        Length = 4740,
                        MaxSpeed = 180,
                        Torque = 288,
                        Weight = 2000,
                        Width = 1845,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "30").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.8,
                        AverageFuelConsumption = 11.2,
                        Clearance = 190,
                        Cylinders = 6,
                        EngineVolume = 3495,
                        EnginePower = 276,
                        FuelTankCapacity = 72,
                        Height = 1679,
                        Length = 4729,
                        MaxSpeed = 200,
                        Torque = 342,
                        Weight = 1835,
                        Width = 1845,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "30r").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 11,
                        AverageFuelConsumption = 9.8,
                        Clearance = 175,
                        Cylinders = 4,
                        EngineVolume = 2672,
                        EnginePower = 188,
                        FuelTankCapacity = 72,
                        Height = 1725,
                        Length = 4770,
                        MaxSpeed = 200,
                        Torque = 252,
                        Weight = 1915,
                        Width = 1885,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "40").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.9,
                        AverageFuelConsumption = 10.6,
                        Clearance = 180,
                        Cylinders = 6,
                        EngineVolume = 3456,
                        EnginePower = 277,
                        FuelTankCapacity = 72,
                        Height = 1725,
                        Length = 4770,
                        MaxSpeed = 200,
                        Torque = 252,
                        Weight = 1915,
                        Width = 1885,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "40").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9.5,
                        AverageFuelConsumption = 7.9,
                        Clearance = 200,
                        Cylinders = 4,
                        EngineVolume = 1998,
                        EnginePower = 238,
                        FuelTankCapacity = 72,
                        Height = 1705,
                        Length = 4890,
                        MaxSpeed = 200,
                        Torque = 350,
                        Weight = 2035,
                        Width = 1895,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "70").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.2,
                        AverageFuelConsumption = 9,
                        Clearance = 200,
                        Cylinders = 6,
                        EngineVolume = 3456,
                        EnginePower = 300,
                        FuelTankCapacity = 65,
                        Height = 1705,
                        Length = 4890,
                        MaxSpeed = 200,
                        Torque = 370,
                        Weight = 2035,
                        Width = 1895,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "70").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 11.7,
                        AverageFuelConsumption = 14.5,
                        Clearance = 210,
                        Cylinders = 6,
                        EngineVolume = 4476,
                        EnginePower = 212,
                        FuelTankCapacity = 0,
                        Height = 1869,
                        Length = 4821,
                        MaxSpeed = 175,
                        Torque = 373,
                        Weight = 2180,
                        Width = 1930,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "1lx").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.9,
                        AverageFuelConsumption = 14.5,
                        Clearance = 220,
                        Cylinders = 8,
                        EngineVolume = 4664,
                        EnginePower = 268,
                        FuelTankCapacity = 96,
                        Height = 1850,
                        Length = 4890,
                        MaxSpeed = 180,
                        Torque = 328,
                        Weight = 2450,
                        Width = 1940,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "2lx").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.5,
                        AverageFuelConsumption = 14.8,
                        Clearance = 225,
                        Cylinders = 8,
                        EngineVolume = 5663,
                        EnginePower = 367,
                        FuelTankCapacity = 93,
                        Height = 1920,
                        Length = 5005,
                        MaxSpeed = 180,
                        Torque = 530,
                        Weight = 2655,
                        Width = 1970,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "3lx").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.9,
                        AverageFuelConsumption = 11.2,
                        Clearance = 200,
                        Cylinders = 6,
                        EngineVolume = 3346,
                        EnginePower = 299,
                        FuelTankCapacity = 80,
                        Height = 1885,
                        Length = 5100,
                        MaxSpeed = 210,
                        Torque = 700,
                        Weight = 2655,
                        Width = 1990,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "4lx").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.8,
                        AverageFuelConsumption = 13.4,
                        Clearance = 200,
                        Cylinders = 6,
                        EngineVolume = 3445,
                        EnginePower = 415,
                        FuelTankCapacity = 80,
                        Height = 1885,
                        Length = 5100,
                        MaxSpeed = 210,
                        Torque = 650,
                        Weight = 2600,
                        Width = 1990,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "4lx").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10,
                        AverageFuelConsumption = 11.6,
                        Clearance = 130,
                        Cylinders = 6,
                        EngineVolume = 2994,
                        EnginePower = 190,
                        FuelTankCapacity = 70,
                        Height = 1370,
                        Length = 4770,
                        MaxSpeed = 210,
                        Torque = 275,
                        Weight = 1530,
                        Width = 1780,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "1es").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.1,
                        AverageFuelConsumption = 9.8,
                        Clearance = 155,
                        Cylinders = 6,
                        EngineVolume = 2995,
                        EnginePower = 210,
                        FuelTankCapacity = 70,
                        Height = 1455,
                        Length = 4855,
                        MaxSpeed = 225,
                        Torque = 299,
                        Weight = 1560,
                        Width = 1810,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "2es").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.5,
                        AverageFuelConsumption = 9.8,
                        Clearance = 155,
                        Cylinders = 6,
                        EngineVolume = 3303,
                        EnginePower = 228,
                        FuelTankCapacity = 70,
                        Height = 1455,
                        Length = 4855,
                        MaxSpeed = 230,
                        Torque = 325,
                        Weight = 1560,
                        Width = 1810,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "2es").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.8,
                        AverageFuelConsumption = 10.2,
                        Clearance = 155,
                        Cylinders = 6,
                        EngineVolume = 3456,
                        EnginePower = 277,
                        FuelTankCapacity = 70,
                        Height = 1450,
                        Length = 4875,
                        MaxSpeed = 230,
                        Torque = 325,
                        Weight = 1635,
                        Width = 1820,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "3es").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 11.6,
                        AverageFuelConsumption = 6.9,
                        Clearance = 151,
                        Cylinders = 4,
                        EngineVolume = 1998,
                        EnginePower = 150,
                        FuelTankCapacity = 65,
                        Height = 1450,
                        Length = 4915,
                        MaxSpeed = 200,
                        Torque = 199,
                        Weight = 1575,
                        Width = 1820,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "4es").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9.8,
                        AverageFuelConsumption = 7.9,
                        Clearance = 151,
                        Cylinders = 4,
                        EngineVolume = 2494,
                        EnginePower = 184,
                        FuelTankCapacity = 65,
                        Height = 1450,
                        Length = 4915,
                        MaxSpeed = 207,
                        Torque = 235,
                        Weight = 1575,
                        Width = 1820,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "4es").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.5,
                        AverageFuelConsumption = 9.5,
                        Clearance = 151,
                        Cylinders = 6,
                        EngineVolume = 3495,
                        EnginePower = 249,
                        FuelTankCapacity = 65,
                        Height = 1450,
                        Length = 4915,
                        MaxSpeed = 210,
                        Torque = 346,
                        Weight = 1575,
                        Width = 1820,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "4es").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.5,
                        AverageFuelConsumption = 5.4,
                        Clearance = 151,
                        Cylinders = 4,
                        EngineVolume = 3495,
                        EnginePower = 161,
                        FuelTankCapacity = 65,
                        Height = 1450,
                        Length = 4915,
                        MaxSpeed = 180,
                        Torque = 213,
                        Weight = 1765,
                        Width = 1820,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "4es").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 12.2,
                        AverageFuelConsumption = 7.1,
                        Clearance = 153,
                        Cylinders = 4,
                        EngineVolume = 1998,
                        EnginePower = 150,
                        FuelTankCapacity = 60,
                        Height = 1445,
                        Length = 4975,
                        MaxSpeed = 210,
                        Torque = 192,
                        Weight = 1700,
                        Width = 1865,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "5es").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9.1,
                        AverageFuelConsumption = 7.9,
                        Clearance = 154,
                        Cylinders = 4,
                        EngineVolume = 2487,
                        EnginePower = 200,
                        FuelTankCapacity = 60,
                        Height = 1445,
                        Length = 4975,
                        MaxSpeed = 210,
                        Torque = 243,
                        Weight = 1700,
                        Width = 1865,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "5es").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.1,
                        AverageFuelConsumption = 5.3,
                        Clearance = 150,
                        Cylinders = 4,
                        EngineVolume = 2487,
                        EnginePower = 218,
                        FuelTankCapacity = 60,
                        Height = 1445,
                        Length = 4975,
                        MaxSpeed = 180,
                        Torque = 243,
                        Weight = 1681,
                        Width = 1865,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "5es").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 12.2,
                        AverageFuelConsumption = 5.6,
                        Clearance = 175,
                        Cylinders = 4,
                        EngineVolume = 1298,
                        EnginePower = 87,
                        FuelTankCapacity = 45,
                        Height = 1530,
                        Length = 3855,
                        MaxSpeed = 170,
                        Torque = 121,
                        Weight = 1010,
                        Width = 1695,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "ist1").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 11.5,
                        AverageFuelConsumption = 6.1,
                        Clearance = 155,
                        Cylinders = 4,
                        EngineVolume = 1496,
                        EnginePower = 109,
                        FuelTankCapacity = 45,
                        Height = 1530,
                        Length = 3855,
                        MaxSpeed = 170,
                        Torque = 141,
                        Weight = 1030,
                        Width = 1695,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "ist1").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 11,
                        AverageFuelConsumption = 6.5,
                        Clearance = 165,
                        Cylinders = 4,
                        EngineVolume = 1794,
                        EnginePower = 132,
                        FuelTankCapacity = 45,
                        Height = 1525,
                        Length = 3930,
                        MaxSpeed = 170,
                        Torque = 174,
                        Weight = 1150,
                        Width = 1725,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "ist2").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 11,
                        AverageFuelConsumption = 5.6,
                        Clearance = 165,
                        Cylinders = 4,
                        EngineVolume = 1794,
                        EnginePower = 109,
                        FuelTankCapacity = 45,
                        Height = 1525,
                        Length = 3930,
                        MaxSpeed = 170,
                        Torque = 141,
                        Weight = 1150,
                        Width = 1725,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "ist2").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 11.7,
                        AverageFuelConsumption = 9.6,
                        Clearance = 145,
                        Cylinders = 4,
                        EngineVolume = 2164,
                        EnginePower = 131,
                        FuelTankCapacity = 60,
                        Height = 1430,
                        Length = 4765,
                        MaxSpeed = 195,
                        Torque = 196,
                        Weight = 1400,
                        Width = 1785,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "XV20").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.5,
                        AverageFuelConsumption = 9.8,
                        Clearance = 145,
                        Cylinders = 6,
                        EngineVolume = 2164,
                        EnginePower = 200,
                        FuelTankCapacity = 60,
                        Height = 1430,
                        Length = 4765,
                        MaxSpeed = 195,
                        Torque = 245,
                        Weight = 1440,
                        Width = 1785,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "XV20").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9,
                        AverageFuelConsumption = 10.6,
                        Clearance = 132,
                        Cylinders = 6,
                        EngineVolume = 1995,
                        EnginePower = 190,
                        FuelTankCapacity = 60,
                        Height = 1430,
                        Length = 4765,
                        MaxSpeed = 220,
                        Torque = 275,
                        Weight = 1445,
                        Width = 1785,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "XV20").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.5,
                        AverageFuelConsumption = 8.2,
                        Clearance = 150,
                        Cylinders = 4,
                        EngineVolume = 2362,
                        EnginePower = 152,
                        FuelTankCapacity = 70,
                        Height = 1430,
                        Length = 4815,
                        MaxSpeed = 200,
                        Torque = 220,
                        Weight = 1390,
                        Width = 1795,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "XV30").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9,
                        AverageFuelConsumption = 10.2,
                        Clearance = 150,
                        Cylinders = 6,
                        EngineVolume = 2995,
                        EnginePower = 190,
                        FuelTankCapacity = 70,
                        Height = 1430,
                        Length = 4815,
                        MaxSpeed = 200,
                        Torque = 267,
                        Weight = 1515,
                        Width = 1795,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "XV30").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.8,
                        AverageFuelConsumption = 9.9,
                        Clearance = 160,
                        Cylinders = 6,
                        EngineVolume = 3456,
                        EnginePower = 277,
                        FuelTankCapacity = 70,
                        Height = 1480,
                        Length = 4815,
                        MaxSpeed = 230,
                        Torque = 346,
                        Weight = 1540,
                        Width = 1820,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "XV40").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9,
                        AverageFuelConsumption = 7.8,
                        Clearance = 160,
                        Cylinders = 4,
                        EngineVolume = 2494,
                        EnginePower = 179,
                        FuelTankCapacity = 70,
                        Height = 1480,
                        Length = 4815,
                        MaxSpeed = 210,
                        Torque = 233,
                        Weight = 1510,
                        Width = 1820,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "XV40").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.4,
                        AverageFuelConsumption = 7.2,
                        Clearance = 160,
                        Cylinders = 4,
                        EngineVolume = 1998,
                        EnginePower = 150,
                        FuelTankCapacity = 70,
                        Height = 1480,
                        Length = 4850,
                        MaxSpeed = 210,
                        Torque = 199,
                        Weight = 1530,
                        Width = 1825,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "XV50").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9,
                        AverageFuelConsumption = 7.8,
                        Clearance = 160,
                        Cylinders = 4,
                        EngineVolume = 2494,
                        EnginePower = 181,
                        FuelTankCapacity = 70,
                        Height = 1480,
                        Length = 4850,
                        MaxSpeed = 210,
                        Torque = 231,
                        Weight = 1540,
                        Width = 1825,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "XV50").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.1,
                        AverageFuelConsumption = 9.3,
                        Clearance = 160,
                        Cylinders = 6,
                        EngineVolume = 3456,
                        EnginePower = 249,
                        FuelTankCapacity = 70,
                        Height = 1480,
                        Length = 4850,
                        MaxSpeed = 210,
                        Torque = 246,
                        Weight = 1615,
                        Width = 1825,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "XV50").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9.5,
                        AverageFuelConsumption = 6,
                        Clearance = 155,
                        Cylinders = 4,
                        EngineVolume = 1987,
                        EnginePower = 150,
                        FuelTankCapacity = 60,
                        Height = 1455,
                        Length = 4885,
                        MaxSpeed = 210,
                        Torque = 206,
                        Weight = 1560,
                        Width = 1840,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "XV70").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.7,
                        AverageFuelConsumption = 6.8,
                        Clearance = 155,
                        Cylinders = 4,
                        EngineVolume = 2487,
                        EnginePower = 200,
                        FuelTankCapacity = 60,
                        Height = 1455,
                        Length = 4885,
                        MaxSpeed = 210,
                        Torque = 243,
                        Weight = 1560,
                        Width = 1840,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "XV70").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.4,
                        AverageFuelConsumption = 9,
                        Clearance = 145,
                        Cylinders = 6,
                        EngineVolume = 3456,
                        EnginePower = 301,
                        FuelTankCapacity = 60,
                        Height = 1455,
                        Length = 4885,
                        MaxSpeed = 240,
                        Torque = 363,
                        Weight = 1623,
                        Width = 1840,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "XV70").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 13.6,
                        AverageFuelConsumption = 11.1,
                        Clearance = 220,
                        Cylinders = 6,
                        EngineVolume = 4164,
                        EnginePower = 204,
                        FuelTankCapacity = 96,
                        Height = 1890,
                        Length = 4885,
                        MaxSpeed = 170,
                        Torque = 430,
                        Weight = 2650,
                        Width = 1940,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "100 Series").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 11.2,
                        AverageFuelConsumption = 16.3,
                        Clearance = 220,
                        Cylinders = 6,
                        EngineVolume = 4476,
                        EnginePower = 224,
                        FuelTankCapacity = 96,
                        Height = 1890,
                        Length = 4885,
                        MaxSpeed = 180,
                        Torque = 387,
                        Weight = 2345,
                        Width = 1940,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "100 Series").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 11.2,
                        AverageFuelConsumption = 16.6,
                        Clearance = 220,
                        Cylinders = 8,
                        EngineVolume = 4664,
                        EnginePower = 235,
                        FuelTankCapacity = 96,
                        Height = 1890,
                        Length = 4885,
                        MaxSpeed = 175,
                        Torque = 434,
                        Weight = 2260,
                        Width = 1940,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "100 Series").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.9,
                        AverageFuelConsumption = 8.1,
                        Clearance = 225,
                        Cylinders = 8,
                        EngineVolume = 4461,
                        EnginePower = 235,
                        FuelTankCapacity = 93,
                        Height = 1950,
                        Length = 4950,
                        MaxSpeed = 200,
                        Torque = 434,
                        Weight = 2585,
                        Width = 1970,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "200 Series").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.6,
                        AverageFuelConsumption = 13.6,
                        Clearance = 225,
                        Cylinders = 8,
                        EngineVolume = 4608,
                        EnginePower = 309,
                        FuelTankCapacity = 93,
                        Height = 1950,
                        Length = 4950,
                        MaxSpeed = 205,
                        Torque = 439,
                        Weight = 2585,
                        Width = 1970,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "200 Series").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.5,
                        AverageFuelConsumption = 15,
                        Clearance = 225,
                        Cylinders = 8,
                        EngineVolume = 5663,
                        EnginePower = 381,
                        FuelTankCapacity = 93,
                        Height = 1950,
                        Length = 4950,
                        MaxSpeed = 205,
                        Torque = 543,
                        Weight = 2614,
                        Width = 1970,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "200 Series").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.8,
                        AverageFuelConsumption = 12.1,
                        Clearance = 230,
                        Cylinders = 6,
                        EngineVolume = 3445,
                        EnginePower = 415,
                        FuelTankCapacity = 110,
                        Height = 1950,
                        Length = 4950,
                        MaxSpeed = 210,
                        Torque = 543,
                        Weight = 2485,
                        Width = 1980,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "300 Series").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.7,
                        AverageFuelConsumption = 10.6,
                        Clearance = 312,
                        Cylinders = 6,
                        EngineVolume = 3956,
                        EnginePower = 275,
                        FuelTankCapacity = 110,
                        Height = 1950,
                        Length = 4950,
                        MaxSpeed = 190,
                        Torque = 385,
                        Weight = 2375,
                        Width = 1980,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "300 Series").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.8,
                        AverageFuelConsumption = 8.9,
                        Clearance = 230,
                        Cylinders = 6,
                        EngineVolume = 3346,
                        EnginePower = 299,
                        FuelTankCapacity = 110,
                        Height = 1950,
                        Length = 4950,
                        MaxSpeed = 210,
                        Torque = 700,
                        Weight = 2495,
                        Width = 1980,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "300 Series").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 13.9,
                        AverageFuelConsumption = 10.1,
                        Clearance = 120,
                        Cylinders = 6,
                        EngineVolume = 1991,
                        EnginePower = 129,
                        FuelTankCapacity = 80,
                        Height = 1412,
                        Length = 4720,
                        MaxSpeed = 198,
                        Torque = 162,
                        Weight = 1400,
                        Width = 1751,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E34").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9.5,
                        AverageFuelConsumption = 9.8,
                        Clearance = 120,
                        Cylinders = 6,
                        EngineVolume = 2494,
                        EnginePower = 192,
                        FuelTankCapacity = 80,
                        Height = 1412,
                        Length = 4720,
                        MaxSpeed = 225,
                        Torque = 250,
                        Weight = 1500,
                        Width = 1751,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E34").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.8,
                        AverageFuelConsumption = 11.1,
                        Clearance = 120,
                        Cylinders = 6,
                        EngineVolume = 2986,
                        EnginePower = 188,
                        FuelTankCapacity = 80,
                        Height = 1412,
                        Length = 4720,
                        MaxSpeed = 225,
                        Torque = 260,
                        Weight = 1500,
                        Width = 1751,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E34").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9.1,
                        AverageFuelConsumption = 11.5,
                        Clearance = 120,
                        Cylinders = 6,
                        EngineVolume = 2986,
                        EnginePower = 211,
                        FuelTankCapacity = 80,
                        Height = 1412,
                        Length = 4720,
                        MaxSpeed = 225,
                        Torque = 305,
                        Weight = 1545,
                        Width = 1751,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E34").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.8,
                        AverageFuelConsumption = 11.4,
                        Clearance = 120,
                        Cylinders = 6,
                        EngineVolume = 3982,
                        EnginePower = 286,
                        FuelTankCapacity = 80,
                        Height = 1412,
                        Length = 4720,
                        MaxSpeed = 225,
                        Torque = 400,
                        Weight = 1605,
                        Width = 1751,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E34").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 11,
                        AverageFuelConsumption = 7,
                        Clearance = 120,
                        Cylinders = 6,
                        EngineVolume = 2498,
                        EnginePower = 143,
                        FuelTankCapacity = 80,
                        Height = 1412,
                        Length = 4720,
                        MaxSpeed = 225,
                        Torque = 260,
                        Weight = 1513,
                        Width = 1751,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E34").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9.1,
                        AverageFuelConsumption = 8.1,
                        Clearance = 120,
                        Cylinders = 6,
                        EngineVolume = 2498,
                        EnginePower = 163,
                        FuelTankCapacity = 70,
                        Height = 1435,
                        Length = 4775,
                        MaxSpeed = 219,
                        Torque = 350,
                        Weight = 1595,
                        Width = 1800,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E39").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 9.1,
                        AverageFuelConsumption = 9.9,
                        Clearance = 120,
                        Cylinders = 6,
                        EngineVolume = 2171,
                        EnginePower = 170,
                        FuelTankCapacity = 70,
                        Height = 1435,
                        Length = 4775,
                        MaxSpeed = 200,
                        Torque = 210,
                        Weight = 1495,
                        Width = 1800,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E39").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.6,
                        AverageFuelConsumption = 10.7,
                        Clearance = 120,
                        Cylinders = 6,
                        EngineVolume = 2979,
                        EnginePower = 231,
                        FuelTankCapacity = 70,
                        Height = 1435,
                        Length = 4775,
                        MaxSpeed = 244,
                        Torque = 300,
                        Weight = 1530,
                        Width = 1800,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E39").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.5,
                        AverageFuelConsumption = 12,
                        Clearance = 120,
                        Cylinders = 8,
                        EngineVolume = 4398,
                        EnginePower = 286,
                        FuelTankCapacity = 70,
                        Height = 1435,
                        Length = 4775,
                        MaxSpeed = 244,
                        Torque = 420,
                        Weight = 1615,
                        Width = 1800,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E39").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 10.6,
                        AverageFuelConsumption = 8.2,
                        Clearance = 142,
                        Cylinders = 4,
                        EngineVolume = 1995,
                        EnginePower = 156,
                        FuelTankCapacity = 70,
                        Height = 1468,
                        Length = 4841,
                        MaxSpeed = 244,
                        Torque = 200,
                        Weight = 1640,
                        Width = 1846,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E60/61").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.6,
                        AverageFuelConsumption = 9.3,
                        Clearance = 142,
                        Cylinders = 6,
                        EngineVolume = 2996,
                        EnginePower = 272,
                        FuelTankCapacity = 70,
                        Height = 1468,
                        Length = 4841,
                        MaxSpeed = 250,
                        Torque = 320,
                        Weight = 1615,
                        Width = 1846,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E60/61").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.2,
                        AverageFuelConsumption = 10.4,
                        Clearance = 142,
                        Cylinders = 8,
                        EngineVolume = 4000,
                        EnginePower = 306,
                        FuelTankCapacity = 70,
                        Height = 1468,
                        Length = 4841,
                        MaxSpeed = 250,
                        Torque = 390,
                        Weight = 1735,
                        Width = 1846,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E60/61").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.4,
                        AverageFuelConsumption = 6.7,
                        Clearance = 142,
                        Cylinders = 6,
                        EngineVolume = 2993,
                        EnginePower = 286,
                        FuelTankCapacity = 70,
                        Height = 1468,
                        Length = 4841,
                        MaxSpeed = 250,
                        Torque = 580,
                        Weight = 1735,
                        Width = 1846,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E60/61").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.9,
                        AverageFuelConsumption = 6,
                        Clearance = 141,
                        Cylinders = 4,
                        EngineVolume = 1997,
                        EnginePower = 184,
                        FuelTankCapacity = 70,
                        Height = 1464,
                        Length = 4907,
                        MaxSpeed = 233,
                        Torque = 270,
                        Weight = 1615,
                        Width = 1860,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "F10/F11/F07").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5.6,
                        AverageFuelConsumption = 7.6,
                        Clearance = 141,
                        Cylinders = 6,
                        EngineVolume = 2979,
                        EnginePower = 306,
                        FuelTankCapacity = 70,
                        Height = 1464,
                        Length = 4907,
                        MaxSpeed = 250,
                        Torque = 400,
                        Weight = 1765,
                        Width = 1860,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "F10/F11/F07").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 4.6,
                        AverageFuelConsumption = 8.6,
                        Clearance = 141,
                        Cylinders = 8,
                        EngineVolume = 4395,
                        EnginePower = 449,
                        FuelTankCapacity = 70,
                        Height = 1464,
                        Length = 4907,
                        MaxSpeed = 250,
                        Torque = 650,
                        Weight = 1830,
                        Width = 1860,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "F10/F11/F07").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5.7,
                        AverageFuelConsumption = 5.4,
                        Clearance = 141,
                        Cylinders = 6,
                        EngineVolume = 2993,
                        EnginePower = 258,
                        FuelTankCapacity = 70,
                        Height = 1464,
                        Length = 4907,
                        MaxSpeed = 250,
                        Torque = 560,
                        Weight = 1810,
                        Width = 1860,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "F10/F11/F07").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 7.9,
                        AverageFuelConsumption = 5.5,
                        Clearance = 144,
                        Cylinders = 4,
                        EngineVolume = 1998,
                        EnginePower = 184,
                        FuelTankCapacity = 68,
                        Height = 1479,
                        Length = 4963,
                        MaxSpeed = 235,
                        Torque = 290,
                        Weight = 1610,
                        Width = 1868,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "G30/G31").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 4.8,
                        AverageFuelConsumption = 7.4,
                        Clearance = 139,
                        Cylinders = 6,
                        EngineVolume = 2998,
                        EnginePower = 340,
                        FuelTankCapacity = 68,
                        Height = 1479,
                        Length = 4963,
                        MaxSpeed = 250,
                        Torque = 450,
                        Weight = 1660,
                        Width = 1868,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "G30/G31").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 3.8,
                        AverageFuelConsumption = 10,
                        Clearance = 131,
                        Cylinders = 8,
                        EngineVolume = 4395,
                        EnginePower = 530,
                        FuelTankCapacity = 68,
                        Height = 1479,
                        Length = 4963,
                        MaxSpeed = 280,
                        Torque = 750,
                        Weight = 1915,
                        Width = 1868,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "G30/G31").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5.6,
                        AverageFuelConsumption = 4.6,
                        Clearance = 144,
                        Cylinders = 6,
                        EngineVolume = 2993,
                        EnginePower = 286,
                        FuelTankCapacity = 68,
                        Height = 1479,
                        Length = 4963,
                        MaxSpeed = 250,
                        Torque = 650,
                        Weight = 1760,
                        Width = 1868,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "G30/G31").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 4.7,
                        AverageFuelConsumption = 11.1,
                        Clearance = 221,
                        Cylinders = 8,
                        EngineVolume = 4395,
                        EnginePower = 530,
                        FuelTankCapacity = 83,
                        Height = 1805,
                        Length = 5151,
                        MaxSpeed = 250,
                        Torque = 750,
                        Weight = 2555,
                        Width = 2000,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "G07").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.1,
                        AverageFuelConsumption = 9.5,
                        Clearance = 221,
                        Cylinders = 6,
                        EngineVolume = 2998,
                        EnginePower = 340,
                        FuelTankCapacity = 83,
                        Height = 1805,
                        Length = 5151,
                        MaxSpeed = 250,
                        Torque = 450,
                        Weight = 2320,
                        Width = 2000,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "G07").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 8.8,
                        AverageFuelConsumption = 12.9,
                        Clearance = 203,
                        Cylinders = 6,
                        EngineVolume = 2979,
                        EnginePower = 231,
                        FuelTankCapacity = 93,
                        Height = 1872,
                        Length = 4667,
                        MaxSpeed = 240,
                        Torque = 300,
                        Weight = 2025,
                        Width = 1872,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E53").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.1,
                        AverageFuelConsumption = 13.5,
                        Clearance = 203,
                        Cylinders = 8,
                        EngineVolume = 4799,
                        EnginePower = 360,
                        FuelTankCapacity = 93,
                        Height = 1872,
                        Length = 4667,
                        MaxSpeed = 246,
                        Torque = 500,
                        Weight = 2205,
                        Width = 1872,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E53").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.6,
                        AverageFuelConsumption = 7.5,
                        Clearance = 222,
                        Cylinders = 6,
                        EngineVolume = 4799,
                        EnginePower = 306,
                        FuelTankCapacity = 93,
                        Height = 1766,
                        Length = 4857,
                        MaxSpeed = 246,
                        Torque = 600,
                        Weight = 2185,
                        Width = 1933,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E70").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.8,
                        AverageFuelConsumption = 10.1,
                        Clearance = 222,
                        Cylinders = 6,
                        EngineVolume = 2979,
                        EnginePower = 306,
                        FuelTankCapacity = 85,
                        Height = 1766,
                        Length = 4857,
                        MaxSpeed = 235,
                        Torque = 400,
                        Weight = 2145,
                        Width = 1933,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "E70").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 6.5,
                        AverageFuelConsumption = 8.5,
                        Clearance = 209,
                        Cylinders = 6,
                        EngineVolume = 2979,
                        EnginePower = 306,
                        FuelTankCapacity = 85,
                        Height = 1762,
                        Length = 4886,
                        MaxSpeed = 235,
                        Torque = 400,
                        Weight = 2030,
                        Width = 1933,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "F15").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5,
                        AverageFuelConsumption = 10.4,
                        Clearance = 209,
                        Cylinders = 8,
                        EngineVolume = 4395,
                        EnginePower = 450,
                        FuelTankCapacity = 85,
                        Height = 1762,
                        Length = 4886,
                        MaxSpeed = 250,
                        Torque = 650,
                        Weight = 2175,
                        Width = 1933,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "F15").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5.5,
                        AverageFuelConsumption = 9.2,
                        Clearance = 214,
                        Cylinders = 6,
                        EngineVolume = 2998,
                        EnginePower = 340,
                        FuelTankCapacity = 83,
                        Height = 1745,
                        Length = 4922,
                        MaxSpeed = 230,
                        Torque = 450,
                        Weight = 2060,
                        Width = 2004,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "G05").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 4.3,
                        AverageFuelConsumption = 10.7,
                        Clearance = 214,
                        Cylinders = 8,
                        EngineVolume = 4395,
                        EnginePower = 530,
                        FuelTankCapacity = 83,
                        Height = 1745,
                        Length = 4922,
                        MaxSpeed = 250,
                        Torque = 750,
                        Weight = 2325,
                        Width = 2004,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "G05").Id
                    },
                    new CarCharacteristics()
                    {
                        AccelerationTime = 5.2,
                        AverageFuelConsumption = 7.2,
                        Clearance = 214,
                        Cylinders = 6,
                        EngineVolume = 2993,
                        EnginePower = 400,
                        FuelTankCapacity = 80,
                        Height = 1745,
                        Length = 4922,
                        MaxSpeed = 250,
                        Torque = 760,
                        Weight = 2275,
                        Width = 2004,
                        GenerationId = context.Generations.FirstOrDefault(x => x.BodyName == "G05").Id
                    });
            }
        }
    }
}
