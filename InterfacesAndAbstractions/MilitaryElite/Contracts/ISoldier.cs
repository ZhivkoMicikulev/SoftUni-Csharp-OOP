﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P07.MilitaryElite.Contracts
{
   public interface ISoldier

    {
        int Id { get; }
        string FirstName { get; }
        string LastName { get; }
    }
}
