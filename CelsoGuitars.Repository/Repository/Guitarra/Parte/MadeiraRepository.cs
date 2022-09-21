﻿using CelsoGuitars.Domain.Guitarra.Parte;
using CelsoGuitars.Domain.Guitarra.Repository.Parte;
using CelsoGuitars.Repository.Context;
using CelsoGuitars.Repository.Database;

namespace CelsoGuitars.Repository.Repository.Guitarra.Parte
{
    public class MadeiraRepository : Repository<Madeira>, IMadeiraRepository
    {
        public MadeiraRepository(CelsoGuitarsContext context) : base(context)
        {
        }
    }
}
