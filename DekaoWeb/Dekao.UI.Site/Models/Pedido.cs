﻿using System;

namespace Dekao.UI.Site.Models
{
    public class Pedido
    {
        public Guid Id { get; set; }

        public Pedido() 
        { 
            Id = Guid.NewGuid();
        }
    }
}
