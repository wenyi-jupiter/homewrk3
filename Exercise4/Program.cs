using System;

namespace Exercise4
{
    class studentandteachertest
    {
        static void Main(string[] args)
        {
            person p = new person();
            p.sayhello();
            student s = new student();
            s.setage(21);
            s.sayhello();
            s.showage();
            teacher t = new teacher();
            t.sayhello();
            t.explain();

        }
    }
}
