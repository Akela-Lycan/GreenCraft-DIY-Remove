using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;

namespace GreenCraft_DIY
{
    public class Card
    {
        public int CardId { get; set; }
        public string CardNumber { get; set; }
        public string ExpiryDate { get; set; }
        public string CVV { get; set; }
    }
    public class ApplicationDbContext : DbContext
    {
        public DbSet<Card> Cards { get; set; }
        // Add other DbSets and configurations
    }
    public class CardService
    {
        private readonly ApplicationDbContext _context;

        public CardService(ApplicationDbContext context)
        {
            _context = context;
        }

        public void SaveCard(Card card)
        {
            _context.Cards.Add(card);
            _context.SaveChanges();
        }

        public void UpdateCard(Card card)
        {
            _context.Entry(card).State = EntityState.Modified;
            _context.SaveChanges();
        }

        public void DeleteCard(int cardId)
        {
            var card = _context.Cards.Find(cardId);
            if (card != null)
            {
                _context.Cards.Remove(card);
                _context.SaveChanges();
            }
        }
    }