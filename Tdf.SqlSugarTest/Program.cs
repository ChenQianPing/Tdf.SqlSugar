using SqlSugarRepository;
using System;
using System.Linq;
using Tdf.SqlSugar;
using Tdf.SqlSugarTest.Entities;

namespace Tdf.SqlSugarTest
{
    class Program
    {
        static void Main(string[] args)
        {
            using (SqlSugarRepositoryBase db = new SqlSugarRepositoryBase())
            {
                Console.WriteLine("1.默认数据库为SqlServer数据库");


                var list = db.Database.Queryable<Entities.Action>("Act_Action").ToList();
                foreach (var item in list)
                {
                    Console.WriteLine(item.ActionId + " " + item.ActionName + " " + item.ActionValue);
                }

                Console.WriteLine("\n");
                Console.WriteLine("2.切换到Oracle数据库");
                db.SetCurrent(db.OracleConnection);
                var list2 = db.Database.Queryable<Db>("T_SYS_DB").ToList();
                foreach (var item in list2)
                {
                    Console.WriteLine(item.DB_ID + " " + item.DB_NAME + " " + item.DB_TYPE);
                }

                Console.WriteLine("\n");
                Console.WriteLine("3.切换到SqlServer数据库");
                db.SetCurrent(db.SqlServerConnection);

                // 拉姆达
                var entity = db.Database.Queryable<Entities.Action>("Act_Action").SingleOrDefault(c => c.ActionValue == 64);
                Console.WriteLine(entity.ActionId + " " + entity.ActionName + " " + entity.ActionValue);

                var list3 = db.Database.Queryable<Entities.Action>("Act_Action").ToList();
                foreach (var item in list3)
                {
                    Console.WriteLine(item.ActionId + " " + item.ActionName + " " + item.ActionValue);
                }

                Console.Read();
            }
        }
    }

    
}
