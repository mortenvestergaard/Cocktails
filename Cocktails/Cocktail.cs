﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cocktails
{
    public class Cocktail :ICocktail
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public List<CocktailIngredients> Ingredients { get; set; }
    }
}
