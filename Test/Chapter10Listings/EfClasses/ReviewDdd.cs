﻿// Copyright (c) 2017 Jon P Smith, GitHub: JonPSmith, web: http://www.thereformedprogrammer.net/
// Licensed under MIT licence. See License.txt in the project root for license information.

using System.ComponentModel.DataAnnotations;

namespace Test.Chapter10Listings.EfClasses
{
    public class ReviewDdd
    {
        public const int NameLength = 100;

        public int ReviewId { get; set; }
        [MaxLength(NameLength)]
        public string VoterName { get; set; }
        public int NumStars { get; set; }
        public string Comment { get; set; }

        //-----------------------------------------
        //Relationships

        public int BookId { get; set; }

        internal ReviewDdd()
        {
        }
    }

}