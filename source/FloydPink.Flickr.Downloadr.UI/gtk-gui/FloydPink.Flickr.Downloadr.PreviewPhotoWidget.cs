// This file has been generated by the GUI designer. Do not modify.
using Gdk;
using Gtk;
using Mono.Unix;
using Stetic;
using Image = Gtk.Image;

namespace FloydPink.Flickr.Downloadr {
    public partial class PreviewPhotoWidget {
        private HBox hbox1;
        private Image imagePreview;
        private Label labelCaption;
        private VBox vbox1;

        protected virtual void Build() {
            Gui.Initialize(this);
            // Widget FloydPink.Flickr.Downloadr.PreviewPhotoWidget
            BinContainer.Attach(this);
            Name = "FloydPink.Flickr.Downloadr.PreviewPhotoWidget";
            // Container child FloydPink.Flickr.Downloadr.PreviewPhotoWidget.Gtk.Container+ContainerChild
            this.vbox1 = new VBox();
            this.vbox1.Name = "vbox1";
            this.vbox1.Spacing = 6;
            // Container child vbox1.Gtk.Box+BoxChild
            this.imagePreview = new Image();
            this.imagePreview.Name = "imagePreview";
            this.imagePreview.Pixbuf = Pixbuf.LoadFromResource("FloydPink.Flickr.Downloadr.Assets.icon.png");
            this.vbox1.Add(this.imagePreview);
            var w1 = ((Box.BoxChild) (this.vbox1[this.imagePreview]));
            w1.Position = 0;
            // Container child vbox1.Gtk.Box+BoxChild
            this.hbox1 = new HBox();
            this.hbox1.Name = "hbox1";
            this.hbox1.Spacing = 6;
            // Container child hbox1.Gtk.Box+BoxChild
            this.labelCaption = new Label();
            this.labelCaption.Name = "labelCaption";
            this.labelCaption.LabelProp = Catalog.GetString("PhotoCaption");
            this.labelCaption.UseMarkup = true;
            this.hbox1.Add(this.labelCaption);
            var w2 = ((Box.BoxChild) (this.hbox1[this.labelCaption]));
            w2.Position = 0;
            this.vbox1.Add(this.hbox1);
            var w3 = ((Box.BoxChild) (this.vbox1[this.hbox1]));
            w3.Position = 1;
            w3.Expand = false;
            w3.Fill = false;
            Add(this.vbox1);
            if ((Child != null)) {
                Child.ShowAll();
            }
            Hide();
        }
    }
}
