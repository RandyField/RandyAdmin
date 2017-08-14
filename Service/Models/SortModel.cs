using EFModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Service.Models
{
    public class SortModel
    {
        public List<Zhp_GameRecord> Single { get; set; }
        public List<Zhp_GameRecord> Flower { get; set; }
        public List<Zhp_GameRecord> Chocolate { get; set; }
    }
}