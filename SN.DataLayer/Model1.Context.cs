﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SN.DataLayer
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class SocialNetDBEntities : DbContext
    {
        public SocialNetDBEntities()
            : base("name=SocialNetDBEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Comment> Comments { get; set; }
        public virtual DbSet<Message> Messages { get; set; }
        public virtual DbSet<MyLike> MyLikes { get; set; }
        public virtual DbSet<MyUser> MyUsers { get; set; }
        public virtual DbSet<Post> Posts { get; set; }
        public virtual DbSet<MyFollow> MyFollows { get; set; }
    }
}
