using System;
using NodaTime;

namespace Cabinizer.Data
{
    public class Period
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = null!;

        public Guid RaffleId { get; set; }

        public Raffle Raffle { get; set; } = null!;

        public LocalDateTime StartTime { get; set; }

        public LocalDateTime EndTime { get; set; }
    }
}