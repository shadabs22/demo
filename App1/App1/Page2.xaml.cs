using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;

namespace App1
{
    public partial class Page2 : ContentPage
    {
        public Page2(string label)
        {
            InitializeComponent();
            MainLabel.Text = label;
            MainListView.ItemsSource = new List<Person> {
                new Person {Name="aaa",Age="18" },
                new Person {Name="bbb",Age="22" },
                new Person {Name="cccc",Age="23" },
                new Person {Name="ddd",Age="21" },
                new Person {Name="eee",Age="25" },
                new Person {Name="ffff",Age="20" },
                new Person {Name="ggg",Age="19" },
                new Person {Name="hhh",Age="18" },
                new Person {Name="iiii",Age="40" },
                new Person {Name="jjj",Age="55" },
                new Person {Name="kkk",Age="56" },
                new Person {Name="lll",Age="57" },
                new Person {Name="mmm",Age="58" },
                new Person {Name="nnn",Age="59" },
                new Person {Name="oooo",Age="70" },
            };
        }
    }
}
