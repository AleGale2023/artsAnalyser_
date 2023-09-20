using Microsoft.EntityFrameworkCore;

namespace DbReliques
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Set> Set { get; set; } = null!;
        public DbSet<State> State { get; set; } = null!;
        public DbSet<Type> Type { get; set; } = null!;
        public DbSet<TypeUpValue> TypeUpValue { get; set; } = null!;
        public DbSet<UpStateValue> UpStateValue { get; set; } = null!;
        public DbSet<Substates> Substates { get; set; } = null!;
        public DbSet<Relique> Relique { get; set; } = null!;

        public ApplicationContext()
        {
            bool isCreated = Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Reliques;Username=admin;Password=123456789");
        }

        internal void Remove(List<Relique> relic)
        {
            Relique.RemoveRange(relic);
            SaveChanges();
        }

        public void Add(List<Type> types)
        {
            Type.AddRange(types);
            SaveChanges();
        }

        public void Add(List<State> states)
        {
            State.AddRange(states);
            SaveChanges();
        }

        public void Add(List<Substates> substs)
        {
            Substates.AddRange(substs);
            SaveChanges();
        }

        public void Add(List<Set> sets)
        {
            Set.AddRange(sets);
            SaveChanges();
        }

        public void Add(List<TypeUpValue> tups)
        {
            TypeUpValue.AddRange(tups);
            SaveChanges();
        }

        private void Add(List<UpStateValue> usvls)
        {
            UpStateValue.AddRange(usvls);
            SaveChanges();
        }
    }
}