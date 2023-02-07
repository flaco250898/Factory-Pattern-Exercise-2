using System;
namespace FactoryPatternExercise2
{
   public static class DataAccessFactory
    {
        public static IDataAccess GetDataAccessType(string databaseType)
        {
            switch (databaseType)
            {
                case "mongo":
                    return new MongoDataAccess();

                case "sql":
                    return new SQLDataAccess();

                case "list":
                    return new ListDataAccess();

                default: 
                    return new ListDataAccess();
            }
        }




    }
}

