using System.ComponentModel;

namespace LibraryWinFormsApp;

partial class FormStatisticBook
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }

        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
        ComponentResourceManager resources = new ComponentResourceManager(typeof(FormStatisticBook));
        LiveChartsCore.Drawing.Padding padding1 = new LiveChartsCore.Drawing.Padding();
        LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip1 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
        LiveChartsCore.Drawing.Padding padding2 = new LiveChartsCore.Drawing.Padding();
        LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend skDefaultLegend2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultLegend();
        LiveChartsCore.Drawing.Padding padding3 = new LiveChartsCore.Drawing.Padding();
        LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip skDefaultTooltip2 = new LiveChartsCore.SkiaSharpView.SKCharts.SKDefaultTooltip();
        LiveChartsCore.Drawing.Padding padding4 = new LiveChartsCore.Drawing.Padding();
        cartesianChart1 = new LiveChartsCore.SkiaSharpView.WinForms.CartesianChart();
        label1 = new Label();
        labelBookAuthors = new Label();
        pieChart1 = new LiveChartsCore.SkiaSharpView.WinForms.PieChart();
        buttonExitBookStats = new Button();
        SuspendLayout();
        // 
        // cartesianChart1
        // 
        cartesianChart1.AutoUpdateEnabled = true;
        cartesianChart1.ChartTheme = null;
        skDefaultLegend1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
        skDefaultLegend1.Content = null;
        skDefaultLegend1.IsValid = false;
        skDefaultLegend1.Opacity = 1F;
        padding1.Bottom = 0F;
        padding1.Left = 0F;
        padding1.Right = 0F;
        padding1.Top = 0F;
        skDefaultLegend1.Padding = padding1;
        skDefaultLegend1.RemoveOnCompleted = false;
        skDefaultLegend1.RotateTransform = 0F;
        skDefaultLegend1.X = 0F;
        skDefaultLegend1.Y = 0F;
        cartesianChart1.Legend = skDefaultLegend1;
        cartesianChart1.Location = new Point(12, 37);
        cartesianChart1.MatchAxesScreenDataRatio = false;
        cartesianChart1.Name = "cartesianChart1";
        cartesianChart1.Size = new Size(776, 256);
        cartesianChart1.TabIndex = 0;
        skDefaultTooltip1.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
        skDefaultTooltip1.Content = null;
        skDefaultTooltip1.IsValid = false;
        skDefaultTooltip1.Opacity = 1F;
        padding2.Bottom = 0F;
        padding2.Left = 0F;
        padding2.Right = 0F;
        padding2.Top = 0F;
        skDefaultTooltip1.Padding = padding2;
        skDefaultTooltip1.RemoveOnCompleted = false;
        skDefaultTooltip1.RotateTransform = 0F;
        skDefaultTooltip1.Wedge = 10;
        skDefaultTooltip1.X = 0F;
        skDefaultTooltip1.Y = 0F;
        cartesianChart1.Tooltip = skDefaultTooltip1;
        cartesianChart1.TooltipFindingStrategy = LiveChartsCore.Measure.TooltipFindingStrategy.Automatic;
        cartesianChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
        cartesianChart1.Load += cartesianChart1_Load_1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 14F);
        label1.Location = new Point(12, 9);
        label1.Name = "label1";
        label1.Size = new Size(223, 25);
        label1.TabIndex = 1;
        label1.Text = "Статистика жанров книг";
        // 
        // labelBookAuthors
        // 
        labelBookAuthors.AutoSize = true;
        labelBookAuthors.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        labelBookAuthors.Location = new Point(12, 296);
        labelBookAuthors.Name = "labelBookAuthors";
        labelBookAuthors.Size = new Size(213, 25);
        labelBookAuthors.TabIndex = 2;
        labelBookAuthors.Text = "Популярность авторов";
        // 
        // pieChart1
        // 
        pieChart1.AutoUpdateEnabled = true;
        pieChart1.ChartTheme = null;
        skDefaultLegend2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
        skDefaultLegend2.Content = null;
        skDefaultLegend2.IsValid = false;
        skDefaultLegend2.Opacity = 1F;
        padding3.Bottom = 0F;
        padding3.Left = 0F;
        padding3.Right = 0F;
        padding3.Top = 0F;
        skDefaultLegend2.Padding = padding3;
        skDefaultLegend2.RemoveOnCompleted = false;
        skDefaultLegend2.RotateTransform = 0F;
        skDefaultLegend2.X = 0F;
        skDefaultLegend2.Y = 0F;
        pieChart1.Legend = skDefaultLegend2;
        pieChart1.Location = new Point(12, 324);
        pieChart1.Name = "pieChart1";
        pieChart1.Size = new Size(300, 300);
        pieChart1.TabIndex = 3;
        skDefaultTooltip2.AnimationsSpeed = TimeSpan.Parse("00:00:00.1500000");
        skDefaultTooltip2.Content = null;
        skDefaultTooltip2.IsValid = false;
        skDefaultTooltip2.Opacity = 1F;
        padding4.Bottom = 0F;
        padding4.Left = 0F;
        padding4.Right = 0F;
        padding4.Top = 0F;
        skDefaultTooltip2.Padding = padding4;
        skDefaultTooltip2.RemoveOnCompleted = false;
        skDefaultTooltip2.RotateTransform = 0F;
        skDefaultTooltip2.Wedge = 10;
        skDefaultTooltip2.X = 0F;
        skDefaultTooltip2.Y = 0F;
        pieChart1.Tooltip = skDefaultTooltip2;
        pieChart1.UpdaterThrottler = TimeSpan.Parse("00:00:00.0500000");
        pieChart1.Load += pieChart1_Load;
        // 
        // buttonExitBookStats
        // 
        buttonExitBookStats.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
        buttonExitBookStats.Location = new Point(695, 580);
        buttonExitBookStats.Name = "buttonExitBookStats";
        buttonExitBookStats.Size = new Size(93, 48);
        buttonExitBookStats.TabIndex = 4;
        buttonExitBookStats.Text = "Закрыть";
        buttonExitBookStats.UseVisualStyleBackColor = true;
        buttonExitBookStats.Click += buttonExitBookStats_Click;
        // 
        // FormStatisticBook
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 640);
        Controls.Add(buttonExitBookStats);
        Controls.Add(pieChart1);
        Controls.Add(labelBookAuthors);
        Controls.Add(label1);
        Controls.Add(cartesianChart1);
        MaximumSize = new Size(816, 679);
        MinimumSize = new Size(816, 679);
        Name = "FormStatisticBook";
        Text = "Статистика книг";
        Load += FormStatisticBook_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private LiveChartsCore.SkiaSharpView.WinForms.CartesianChart cartesianChart1;
    private Label label1;
    private Label labelBookAuthors;
    private LiveChartsCore.SkiaSharpView.WinForms.PieChart pieChart1;
    private Button buttonExitBookStats;
}