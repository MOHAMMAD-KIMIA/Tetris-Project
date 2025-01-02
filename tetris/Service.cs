using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Reflection.Metadata;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using tetris;

namespace tetris
{
    public class Service
    {
        public ScoreContext ScoreContext { get; set; }
        public Service()
        {
            ScoreContext = new ScoreContext();
        }

        public void updatescore(string highScore)
        {
            var score = ScoreContext.Scores.FirstOrDefault();
            if (score == null)
            {
                ScoreContext.Scores.Add(new Score() { ScoreId = highScore });
                ScoreContext.SaveChanges();
                return;
            }
            else
            {
                score!.ScoreId = highScore;
                ScoreContext.Scores.Update(score);
                ScoreContext.SaveChanges();
            }
            
        }

        #region MyRegion



        //using (var db = new ScoreContext())
        //{
        //    var scores = db.Scores
        //        .Where(s => s.ScoreId > 15)
        //        .ToList();
        //}

        //using (var db = new ScoreContext())
        //{
        //    var score = new Score { Url = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\PROJECTS\\tetris\\tetris\\tetris.mdf;Integrated Security=True" };
        //    db.Scores.Add(score);
        //    db.SaveChanges();
        //}
        //}


        #endregion
    }
}