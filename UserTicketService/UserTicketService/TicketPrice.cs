﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserTicketService
{
    public class TicketPrice
    {
        private ITicketService ticketService;

        public TicketPrice(ITicketService ticketService)
        {
            this.ticketService = ticketService;
        }

        public int MakeTicketPrice(int ticketId)
        {
            return ticketService.GetTicketPrice(ticketId);
        }
    }
}
