﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace W3_2018_2C_TP
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities : DbContext
    {
        public Entities()
            : base("name=Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<EstadoPedido> EstadoPedido { get; set; }
        public virtual DbSet<GustoEmpanada> GustoEmpanada { get; set; }
        public virtual DbSet<InvitacionPedido> InvitacionPedido { get; set; }
        public virtual DbSet<InvitacionPedidoGustoEmpanadaUsuario> InvitacionPedidoGustoEmpanadaUsuario { get; set; }
        public virtual DbSet<Pedido> Pedido { get; set; }
        public virtual DbSet<Usuario> Usuario { get; set; }
    }
}
