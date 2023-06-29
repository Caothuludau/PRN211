using System;
using System.Collections.Generic;

namespace EntityFrameworkDemo.Models;

public partial class Order
{
    public int OrderId { get; set; }

    public int? CarId { get; set; }

    public int? CustId { get; set; }

    public virtual Car? Car { get; set; }

    public virtual Customer? Cust { get; set; }
}
