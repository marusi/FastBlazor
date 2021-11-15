using System.Collections.Generic;

namespace BlazorWithIdentity.Shared.DTO.Football
{
   public  class FootballResultDTO<T>
    {
        public IEnumerable<T> Response { get; set; }
    }
}
