using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace REvision
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<Student> students = new List<Student>();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            students = GetStudents();
            lbxStudents.ItemsSource = students;
        }

        private static List<Student> GetStudents()
        {
            Subject su1 = new Subject() { Name = "English", Result = 'A' };
            Subject su2 = new Subject() { Name = "Maths", Result = 'B' };
            Subject su3 = new Subject() { Name = "Spanish", Result = 'C' };
            Subject su4 = new Subject() { Name = "Art", Result = 'A' };
            Subject su5 = new Subject() { Name = "Music", Result = 'B' };

            List<Subject> s1subjects = new List<Subject>();

            s1subjects.Add(su1);
            s1subjects.Add(su2);
            s1subjects.Add(su3);
            s1subjects.Add(su4);
            s1subjects.Add(su5);

            Student s1 = new Student() { Name = "Sarah", Subjects = s1subjects, Age = 30 };

            Subject su6 = new Subject() { Name = "English", Result = 'B' };
            Subject su7 = new Subject() { Name = "Maths", Result = 'C' };
            Subject su8 = new Subject() { Name = "Spanish", Result = 'A' };
            Subject su9 = new Subject() { Name = "Art", Result = 'C' };
            Subject su10 = new Subject() { Name = "Music", Result = 'C' };

            List<Subject> s2subjects = new List<Subject>();
            s2subjects.Add(su6);
            s2subjects.Add(su7);
            s2subjects.Add(su8);
            s2subjects.Add(su9);
            s2subjects.Add(su10);

            Student s2 = new Student() { Name = "Jim", Subjects = s2subjects, Age = 20};

            List<Student> _students = new List<Student>();
            _students.Add(s1);
            _students.Add(s2);

            return _students;
        }

        private void lbxStudents_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Student selected = lbxStudents.SelectedItem as Student;

            if (selected != null)
            {
                lbxSubjects.ItemsSource = selected.Subjects;  //this will use the ToString method of Subject
            }
        }

        private void lbxSubjects_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Subject selected = lbxSubjects.SelectedItem as Subject;

            if (selected != null)
            {
                imgGrade.Source = new BitmapImage(new Uri(selected.GradeImage, UriKind.Relative));
                
                //To have a hardcoded image you would use the code below, check the Subject class to see the GradeImage property
                //imgGrade.Source = new BitmapImage(new Uri("/images/a.png", UriKind.Relative));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            students.Sort();
            lbxStudents.ItemsSource = null;
            lbxStudents.ItemsSource = students;
        }
    }
}
