using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoExpandTester
{
    internal class StartupPage: ContentPage
    {
        public StartupPage()
        {

            var text = "The tattered work gloves speak of the many hours of hard labor he endured throughout his life. He felt that dining on the bridge brought romance to his relationship with his cat.The manager of the fruit stand always sat and only sold vegetables.";
            
            var editor1 = new Editor { Text = $"Editor1: {text}", AutoSize = EditorAutoSizeOption.TextChanges };
            var editor2 = new Editor { Text = $"Editor2: {text}", AutoSize = EditorAutoSizeOption.TextChanges };
            var editor3 = new Editor { Text = $"Editor3: {text}", AutoSize = EditorAutoSizeOption.TextChanges };
            var editor4 = new Editor { Text = $"Editor4: {text}", AutoSize = EditorAutoSizeOption.TextChanges };
            var editor5 = new Editor { Text = $"Editor5: {text}", AutoSize = EditorAutoSizeOption.TextChanges };
            var editor6 = new Editor { Text = $"Editor6: {text}", AutoSize = EditorAutoSizeOption.TextChanges };
            var editor7 = new Editor { Text = $"Editor7: {text}", AutoSize = EditorAutoSizeOption.TextChanges };
            var editor8 = new Editor { Text = $"Editor8: {text}", AutoSize = EditorAutoSizeOption.TextChanges };
            var editor9 = new Editor { Text = $"Editor9: {text}", AutoSize = EditorAutoSizeOption.TextChanges };
            var editor10 = new Editor { Text = $"Editor10: {text}", AutoSize = EditorAutoSizeOption.TextChanges };
            var editor11 = new Editor { Text = $"Editor11: {text}", AutoSize = EditorAutoSizeOption.TextChanges };
            var editor12 = new Editor { Text = $"Editor12: {text}", AutoSize = EditorAutoSizeOption.TextChanges };

            var verticalLayout = new VerticalStackLayout { Children = { editor1 ,editor2, editor3, editor4, editor5, editor6, editor7, editor8, editor9, editor10, editor11, editor12 }, Padding = 30};

            Content = new ScrollView { Content = verticalLayout };

        }
    }
}
