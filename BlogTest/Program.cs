using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Blog;

namespace BlogTest
{
    class Program
    {
        public static void ejemplo0()
        {
            User usr = new User { UserId=Guid.NewGuid(), UserName="marting", Password="holamundo", Email="marting@hola.com" };
            UserRepository usrRep = new UserRepository(new DLContext());
            usrRep.Insert(usr);
            var result = usrRep.getList();

            foreach (var item in result)
            {
                Console.WriteLine(item.UserName);
            }
        }

        public static void ejemplo1()
        {
            Post pst = new Post { PostId=Guid.NewGuid(), Date=DateTime.Now, Text="holamundo" };
            PostRepository pstRep = new PostRepository(new DLContext());
            pstRep.Insert(pst);
            var result = pstRep.getList();

            foreach (var item in result)
            {
                Console.WriteLine(item.Text);
            }
        }

        public static void ejemplo2()
        {
            Comment cmt = new Comment { CommentId=Guid.NewGuid(), Date=DateTime.Now, Text="holamundo" };
            CommentRepository cmtRep = new CommentRepository(new DLContext());
            cmtRep.Insert(cmt);
            var result = cmtRep.getList();

            foreach (var item in result)
            {
                Console.WriteLine(item.Text);
            }
        }

        static void Main(string[] args)
        {
            ejemplo0();
            ejemplo1();
            ejemplo2();
        }
    }
}
