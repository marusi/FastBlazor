using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWithIdentity.Shared.DTO.Football
{
    public class FootballDataDTO
    {
        public string Title { get; set; } 

        public string Competition { get; set;  }

        public string MatchViewUrl { get; set; }

        public string CompetitionUrl {  get; set;}

        public string Thumbnail { get; set; }

        public string Date { get; set; }

        public ICollection<Video> Videos { get; set; }

        public FootballDataDTO()
        {
            Videos = new List<Video>();
        }
    }
}
