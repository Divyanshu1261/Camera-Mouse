// Decompiled with JetBrains decompiler
// Type: b
// Assembly: Camera Mouse 2018, Version=1.1.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 51111F1A-BEB1-4B59-82BC-FB935BB3EA9E
// Assembly location: C:\Program Files (x86)\Camera Mouse\Camera Mouse 2018\Camera Mouse 2018.exe

using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

internal class b : Form
{
  private IContainer a;
  private Panel b;
  private Button c;
  private LinkLabel d;
  private Label e;
  private Label f;
  private Label g;
  private Label h;
  private LinkLabel i;
  private Label j;
  private PictureBox k;
  private Label l;

  public b()
  {
    this.g();
    // ISSUE: reference to a compiler-generated method
    this.Text = "About " + global::e.b();
    this.f.Text = this.k();
    this.e.Text = string.Format("Version {0} {0}", (object) this.i());
    this.h.Text = this.l();
    this.g.Text = this.m();
    // ISSUE: reference to a compiler-generated method
    // ISSUE: reference to a compiler-generated method
    this.d.Text = global::e.b() + " is based on research by Prof. James Gips and Prof. Margrit Betke and their students.\n\n" + global::e.b() + " is designed and directed by Prof.Gips. Software Engineering is by Mekinesis, Inc. under contract from Boston College.";
    LinkLabel d1 = this.d;
    d1.Text = d1.Text + "\n\n\n" + this.j();
    LinkLabel d2 = this.d;
    d2.Text = d2.Text + this.l() + " by the Trustees of Boston College";
    this.d.Links.Add(42, 16, (object) "www.cs.bc.edu/~gips");
    this.d.Links.Add(63, 19, (object) "www.cs.bu.edu/~betke");
    this.d.LinkClicked += new LinkLabelLinkClickedEventHandler(this.g);
    this.i.Text = "For more information visit www.cameramouse.org or email gips@bc.edu";
    this.i.Links.Add(27, 19, (object) "www.cameramouse.org");
    this.i.LinkClicked += new LinkLabelLinkClickedEventHandler(this.h);
    this.j.Text = "Version " + Assembly.GetExecutingAssembly().GetName().Version.ToString(2);
  }

  private void h(object A_0, LinkLabelLinkClickedEventArgs A_1)
  {
    if (!(A_1.Link.LinkData is string linkData) || !linkData.StartsWith("www"))
      return;
    Process.Start(linkData);
  }

  private void g(object A_0, LinkLabelLinkClickedEventArgs A_1)
  {
    string linkData = (string) A_1.Link.LinkData;
    if (linkData == null || !linkData.StartsWith("www"))
      return;
    Process.Start(linkData);
  }

  private void g(object A_0, EventArgs A_1) => this.Close();

  [SpecialName]
  public string h()
  {
    object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyTitleAttribute), false);
    if (customAttributes.Length != 0)
    {
      AssemblyTitleAttribute assemblyTitleAttribute = (AssemblyTitleAttribute) customAttributes[0];
      if (assemblyTitleAttribute.Title != "")
        return assemblyTitleAttribute.Title;
    }
    return Path.GetFileNameWithoutExtension(Assembly.GetExecutingAssembly().CodeBase);
  }

  [SpecialName]
  public string i() => Assembly.GetExecutingAssembly().GetName().Version.ToString();

  [SpecialName]
  public string j()
  {
    object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyDescriptionAttribute), false);
    return customAttributes.Length == 0 ? "" : ((AssemblyDescriptionAttribute) customAttributes[0]).Description;
  }

  [SpecialName]
  public string k()
  {
    object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyProductAttribute), false);
    return customAttributes.Length == 0 ? "" : ((AssemblyProductAttribute) customAttributes[0]).Product;
  }

  [SpecialName]
  public string l()
  {
    object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCopyrightAttribute), false);
    return customAttributes.Length == 0 ? "" : ((AssemblyCopyrightAttribute) customAttributes[0]).Copyright;
  }

  [SpecialName]
  public string m()
  {
    object[] customAttributes = Assembly.GetExecutingAssembly().GetCustomAttributes(typeof (AssemblyCompanyAttribute), false);
    return customAttributes.Length == 0 ? "" : ((AssemblyCompanyAttribute) customAttributes[0]).Company;
  }

  protected override void Dispose(bool disposing)
  {
    if (disposing && this.a != null)
      this.a.Dispose();
    base.Dispose(disposing);
  }

  private void g()
  {
    ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof (global::b));
    this.b = new Panel();
    this.j = new Label();
    this.i = new LinkLabel();
    this.c = new Button();
    this.d = new LinkLabel();
    this.e = new Label();
    this.f = new Label();
    this.g = new Label();
    this.h = new Label();
    this.k = new PictureBox();
    this.l = new Label();
    this.b.SuspendLayout();
    ((ISupportInitialize) this.k).BeginInit();
    this.SuspendLayout();
    this.b.Controls.Add((Control) this.l);
    this.b.Controls.Add((Control) this.j);
    this.b.Controls.Add((Control) this.i);
    this.b.Controls.Add((Control) this.c);
    this.b.Controls.Add((Control) this.d);
    this.b.Controls.Add((Control) this.e);
    this.b.Controls.Add((Control) this.f);
    this.b.Controls.Add((Control) this.g);
    this.b.Controls.Add((Control) this.h);
    this.b.Location = new Point(12, 106);
    this.b.Name = "panel1";
    this.b.Size = new Size(360, 334);
    this.b.TabIndex = 27;
    this.j.AutoSize = true;
    this.j.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.j.Location = new Point(14, 282);
    this.j.Name = "versionLabel";
    this.j.Size = new Size(131, 20);
    this.j.TabIndex = 35;
    this.j.Text = "version number";
    this.i.Anchor = AnchorStyles.None;
    this.i.Location = new Point(28, 189);
    this.i.Name = "link1";
    this.i.Size = new Size(301, 30);
    this.i.TabIndex = 34;
    this.c.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
    this.c.DialogResult = DialogResult.Cancel;
    this.c.Location = new Point(283, 310);
    this.c.Name = "okButton";
    this.c.Size = new Size(75, 23);
    this.c.TabIndex = 33;
    this.c.Text = "&OK";
    this.d.Anchor = AnchorStyles.None;
    this.d.Location = new Point(28, 64);
    this.d.Name = "link2";
    this.d.Size = new Size(301, 129);
    this.d.TabIndex = 32;
    this.e.Anchor = AnchorStyles.None;
    this.e.Location = new Point(115, 38);
    this.e.Margin = new Padding(6, 0, 3, 0);
    this.e.MaximumSize = new Size(0, 17);
    this.e.Name = "labelVersion";
    this.e.Size = new Size(0, 17);
    this.e.TabIndex = 30;
    this.e.Text = "Version";
    this.e.TextAlign = ContentAlignment.MiddleLeft;
    this.f.Anchor = AnchorStyles.None;
    this.f.Location = new Point(115, 12);
    this.f.Margin = new Padding(6, 0, 3, 0);
    this.f.MaximumSize = new Size(0, 17);
    this.f.Name = "labelProductName";
    this.f.Size = new Size(0, 17);
    this.f.TabIndex = 28;
    this.f.Text = "Product Name";
    this.f.TextAlign = ContentAlignment.MiddleLeft;
    this.g.Anchor = AnchorStyles.None;
    this.g.Location = new Point(115, 99);
    this.g.Margin = new Padding(6, 0, 3, 0);
    this.g.MaximumSize = new Size(0, 17);
    this.g.Name = "labelCompanyName";
    this.g.Size = new Size(0, 17);
    this.g.TabIndex = 31;
    this.g.Text = "Company Name";
    this.g.TextAlign = ContentAlignment.MiddleLeft;
    this.h.Anchor = AnchorStyles.None;
    this.h.Location = new Point(115, 68);
    this.h.Margin = new Padding(6, 0, 3, 0);
    this.h.MaximumSize = new Size(0, 17);
    this.h.Name = "labelCopyright";
    this.h.Size = new Size(0, 17);
    this.h.TabIndex = 29;
    this.h.Text = "Copyright";
    this.h.TextAlign = ContentAlignment.MiddleLeft;
    this.k.Image = (Image) componentResourceManager.GetObject("pictureBox1.Image");
    this.k.InitialImage = (Image) componentResourceManager.GetObject("pictureBox1.InitialImage");
    this.k.Location = new Point(40, 12);
    this.k.Name = "pictureBox1";
    this.k.Size = new Size(301, 82);
    this.k.TabIndex = 28;
    this.k.TabStop = false;
    this.l.AutoSize = true;
    this.l.Font = new Font("Microsoft Sans Serif", 12f, FontStyle.Bold, GraphicsUnit.Point, (byte) 0);
    this.l.Location = new Point(14, 251);
    this.l.Name = "label1";
    this.l.Size = new Size(174, 20);
    this.l.TabIndex = 36;
    this.l.Text = "Camera Mouse 2018";
    this.AutoScaleDimensions = new SizeF(6f, 13f);
    this.AutoScaleMode = AutoScaleMode.Font;
    this.ClientSize = new Size(384, 462);
    this.Controls.Add((Control) this.k);
    this.Controls.Add((Control) this.b);
    this.FormBorderStyle = FormBorderStyle.FixedDialog;
    this.Icon = (Icon) componentResourceManager.GetObject("$this.Icon");
    this.MaximizeBox = false;
    this.MinimizeBox = false;
    this.Name = "AboutBox";
    this.Padding = new Padding(9);
    this.ShowInTaskbar = false;
    this.StartPosition = FormStartPosition.CenterParent;
    this.Text = "About Camera Mouse 2018";
    this.b.ResumeLayout(false);
    this.b.PerformLayout();
    ((ISupportInitialize) this.k).EndInit();
    this.ResumeLayout(false);
  }
}
