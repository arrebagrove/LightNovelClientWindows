﻿

#pragma checksum "C:\Users\Yupeng\Source\Workspaces\LightNovelClientWindows\LightNovelClient\LightNovelClient.Windows\ReadingPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "691B12409137C9F62D7A5B6A8764B24B"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace LightNovel
{
    partial class ReadingPage : global::Windows.UI.Xaml.Controls.Page
    {
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Page pageRoot; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Data.CollectionViewSource VolumesViewSource; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Data.CollectionViewSource ChaptersViewSource; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.SolidColorBrush ContentForegroundBrush; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.SolidColorBrush ContentBackgroundBrush; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.SolidColorBrush CommentedTextBrush; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.DataTemplate IllustrationViewTemplate; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Flyout CommentsFlyout; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Flyout ImagePreviewFlyout; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid CommentsTool; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid CommentsInputTool; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBox CommentInputBox; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.CommandBar PageBottomCommandBar; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton DownloadButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarToggleButton CommentEnableButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton ShareButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarToggleButton FavoriteButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarToggleButton PinButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton FontSizeButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton ReadingStyleButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarButton FontFamilyButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ColumnDefinition PrimaryColumn; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ColumnDefinition SecondaryColumn; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualStateGroup IndexPanelStates; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualStateGroup LoadingStates; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualStateGroup FlowOrientation; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState HorizontalFlow; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState VerticalFlow; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState Ready; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState Loading; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState IndexClosed; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.VisualState IndexOpen; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.EasingDoubleKeyFrame ContentExpandedToCollapsedKeyFrame; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.EasingDoubleKeyFrame IndexExpandedToCollapsedKeyFrame; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.EasingDoubleKeyFrame ContentCollapsedToExpandedKeyFrame; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Media.Animation.EasingDoubleKeyFrame IndexCollapsedToExpandedKeyFrame; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid TitlePanel; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid IndexRegion; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid ContentRegion; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ProgressRing LoadingIndicator; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ScrollViewer ContentScrollViewer; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button VerticalPrevButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button VerticalNextButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button HorizontalPrevButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button HorizontalNextButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::LightNovel.Controls.RichTextColumns ContentColumns; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.RichTextBlock ContentTextBlock; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid VolumeListMeanu; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Grid ChapterListMeanu; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView ChapterListView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.ListView VolumeListView; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.Button backButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.AppBarToggleButton IndexButton; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private global::Windows.UI.Xaml.Controls.TextBlock pageTitle; 
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        private bool _contentLoaded;

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 4.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent()
        {
            if (_contentLoaded)
                return;

            _contentLoaded = true;
            global::Windows.UI.Xaml.Application.LoadComponent(this, new global::System.Uri("ms-appx:///ReadingPage.xaml"), global::Windows.UI.Xaml.Controls.Primitives.ComponentResourceLocation.Application);
 
            pageRoot = (global::Windows.UI.Xaml.Controls.Page)this.FindName("pageRoot");
            VolumesViewSource = (global::Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("VolumesViewSource");
            ChaptersViewSource = (global::Windows.UI.Xaml.Data.CollectionViewSource)this.FindName("ChaptersViewSource");
            ContentForegroundBrush = (global::Windows.UI.Xaml.Media.SolidColorBrush)this.FindName("ContentForegroundBrush");
            ContentBackgroundBrush = (global::Windows.UI.Xaml.Media.SolidColorBrush)this.FindName("ContentBackgroundBrush");
            CommentedTextBrush = (global::Windows.UI.Xaml.Media.SolidColorBrush)this.FindName("CommentedTextBrush");
            IllustrationViewTemplate = (global::Windows.UI.Xaml.DataTemplate)this.FindName("IllustrationViewTemplate");
            CommentsFlyout = (global::Windows.UI.Xaml.Controls.Flyout)this.FindName("CommentsFlyout");
            ImagePreviewFlyout = (global::Windows.UI.Xaml.Controls.Flyout)this.FindName("ImagePreviewFlyout");
            CommentsTool = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("CommentsTool");
            CommentsInputTool = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("CommentsInputTool");
            CommentInputBox = (global::Windows.UI.Xaml.Controls.TextBox)this.FindName("CommentInputBox");
            PageBottomCommandBar = (global::Windows.UI.Xaml.Controls.CommandBar)this.FindName("PageBottomCommandBar");
            DownloadButton = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("DownloadButton");
            CommentEnableButton = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.FindName("CommentEnableButton");
            ShareButton = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("ShareButton");
            FavoriteButton = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.FindName("FavoriteButton");
            PinButton = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.FindName("PinButton");
            FontSizeButton = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("FontSizeButton");
            ReadingStyleButton = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("ReadingStyleButton");
            FontFamilyButton = (global::Windows.UI.Xaml.Controls.AppBarButton)this.FindName("FontFamilyButton");
            PrimaryColumn = (global::Windows.UI.Xaml.Controls.ColumnDefinition)this.FindName("PrimaryColumn");
            SecondaryColumn = (global::Windows.UI.Xaml.Controls.ColumnDefinition)this.FindName("SecondaryColumn");
            IndexPanelStates = (global::Windows.UI.Xaml.VisualStateGroup)this.FindName("IndexPanelStates");
            LoadingStates = (global::Windows.UI.Xaml.VisualStateGroup)this.FindName("LoadingStates");
            FlowOrientation = (global::Windows.UI.Xaml.VisualStateGroup)this.FindName("FlowOrientation");
            HorizontalFlow = (global::Windows.UI.Xaml.VisualState)this.FindName("HorizontalFlow");
            VerticalFlow = (global::Windows.UI.Xaml.VisualState)this.FindName("VerticalFlow");
            Ready = (global::Windows.UI.Xaml.VisualState)this.FindName("Ready");
            Loading = (global::Windows.UI.Xaml.VisualState)this.FindName("Loading");
            IndexClosed = (global::Windows.UI.Xaml.VisualState)this.FindName("IndexClosed");
            IndexOpen = (global::Windows.UI.Xaml.VisualState)this.FindName("IndexOpen");
            ContentExpandedToCollapsedKeyFrame = (global::Windows.UI.Xaml.Media.Animation.EasingDoubleKeyFrame)this.FindName("ContentExpandedToCollapsedKeyFrame");
            IndexExpandedToCollapsedKeyFrame = (global::Windows.UI.Xaml.Media.Animation.EasingDoubleKeyFrame)this.FindName("IndexExpandedToCollapsedKeyFrame");
            ContentCollapsedToExpandedKeyFrame = (global::Windows.UI.Xaml.Media.Animation.EasingDoubleKeyFrame)this.FindName("ContentCollapsedToExpandedKeyFrame");
            IndexCollapsedToExpandedKeyFrame = (global::Windows.UI.Xaml.Media.Animation.EasingDoubleKeyFrame)this.FindName("IndexCollapsedToExpandedKeyFrame");
            TitlePanel = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("TitlePanel");
            IndexRegion = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("IndexRegion");
            ContentRegion = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("ContentRegion");
            LoadingIndicator = (global::Windows.UI.Xaml.Controls.ProgressRing)this.FindName("LoadingIndicator");
            ContentScrollViewer = (global::Windows.UI.Xaml.Controls.ScrollViewer)this.FindName("ContentScrollViewer");
            VerticalPrevButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("VerticalPrevButton");
            VerticalNextButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("VerticalNextButton");
            HorizontalPrevButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("HorizontalPrevButton");
            HorizontalNextButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("HorizontalNextButton");
            ContentColumns = (global::LightNovel.Controls.RichTextColumns)this.FindName("ContentColumns");
            ContentTextBlock = (global::Windows.UI.Xaml.Controls.RichTextBlock)this.FindName("ContentTextBlock");
            VolumeListMeanu = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("VolumeListMeanu");
            ChapterListMeanu = (global::Windows.UI.Xaml.Controls.Grid)this.FindName("ChapterListMeanu");
            ChapterListView = (global::Windows.UI.Xaml.Controls.ListView)this.FindName("ChapterListView");
            VolumeListView = (global::Windows.UI.Xaml.Controls.ListView)this.FindName("VolumeListView");
            backButton = (global::Windows.UI.Xaml.Controls.Button)this.FindName("backButton");
            IndexButton = (global::Windows.UI.Xaml.Controls.AppBarToggleButton)this.FindName("IndexButton");
            pageTitle = (global::Windows.UI.Xaml.Controls.TextBlock)this.FindName("pageTitle");
        }
    }
}



