using Microsoft.EntityFrameworkCore;

namespace DbArts
{
    public class ApplicationContext : DbContext
    {
        public DbSet<Set> Set { get; set; } = null!;
        public DbSet<State> State { get; set; } = null!;
        public DbSet<StateIsUpState> StateIsUpState { get; set; } = null!;
        public DbSet<Type> Type { get; set; } = null!;
        public DbSet<TypeUpValue> TypeUpValue { get; set; } = null!;
        public DbSet<UpStateValueLeg> UpStateValueLeg { get; set; } = null!;
        public DbSet<Substates> Substates { get; set; } = null!;
        public DbSet<Art> Arts { get; set; } = null!;

        public ApplicationContext()
        {
            bool isCreated = Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=Artefacts;Username=admin;Password=passw");
        }

        internal void Remove(List<Art> arts)
        {
            Arts.RemoveRange(arts);
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

        private void Add(List<UpStateValueLeg> usvls)
        {
            UpStateValueLeg.AddRange(usvls);
            SaveChanges();
        }
    }
}