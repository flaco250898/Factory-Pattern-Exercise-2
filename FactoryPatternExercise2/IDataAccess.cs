using System;
namespace FactoryPatternExercise2
{
    public interface IDataAccess
    {
        public void SaveData();
        public List<Product> LoadData();
    }
}

