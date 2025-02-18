using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazon
{
    public class Customer
    {
        public string Name { get; set; }
        public int Id { get; set; }

        public void Promote()
        {
            var rating = CalculateRating(excludeorders: true);
            if (rating == 0)
            {
                Console.WriteLine("Level 1");
            }
            else
            {
                Console.WriteLine("Level 2");
            }
        }

        public int CalculateRating(bool excludeorders)
        {
            return 0; // Placeholder logic
        }
    }

}
