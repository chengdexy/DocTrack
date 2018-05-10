using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocTrack.Model
{
    class SubDocument
    {
        public int ID { get; set; }

        //relationship
        public virtual int DocumentID { get; set; }
        public virtual Document Document { get; set; }
        public virtual ICollection<CirculationOperation> CirculationOperations { get; set; }

        //method
        public CirculationOperation LastOperation()
        {
            return CirculationOperations.OrderByDescending(co => co.ID).FirstOrDefault();

        }
    }
}
