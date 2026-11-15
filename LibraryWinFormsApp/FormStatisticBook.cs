using LibraryWinFormsApp.Data;
using LiveChartsCore;
using LiveChartsCore.SkiaSharpView;

namespace LibraryWinFormsApp;

public partial class FormStatisticBook : Form
{
    public readonly LibraryContext _context;
    public FormStatisticBook(LibraryContext context)
    {
        InitializeComponent();
        _context = context;
    }

    private void FormStatisticBook_Load(object sender, EventArgs e)
    {

    }

    private void cartesianChart1_Load(object sender, EventArgs e)
    {

    }

    private void cartesianChart1_Load_1(object sender, EventArgs e)
    {
        // Информация о жанрах книг и их количествах
        var genreData = _context.Books
            .GroupBy(x => x.Genre)
            .Select(g => new
            {
                GenreName = g.Key,
                BookCount = g.Count()
            })
            .OrderBy(u => u.GenreName)
            .ToList();

        // Данные диаграммы
        ISeries[] bookSeries =
        {
            new ColumnSeries<double>
            {
                Name = "Количество книг",
                // Извлекаем только количества и приводим к double
                Values = genreData
                .Select(g => (double)g.BookCount)
                .ToArray()
            }
        };
        // Названия жанров
        Axis[] groupAxis =
        {
            new Axis
            {
                Labels = genreData
                .Select(g => g.GenreName)
                .ToArray(),
                LabelsRotation = 15
            }
        };
        cartesianChart1.Series = bookSeries;
        cartesianChart1.XAxes = groupAxis;
    }

    private void pieChart1_Load(object sender, EventArgs e)
    {
        // Отбор авторов книг и количества книг по ним
        var authorsData = _context.Books
            .GroupBy(x => x.BookAuthor)
            .Select(g => new
            {
                AuthorName = g.Key,
                AuthorBooksCount = g.Count()
            })
            .ToList();
        // Серий круговой диаграммы (легенды)
        var authorsSeries = authorsData
            .Select(d => new PieSeries<double>
            {
                Name = d.AuthorName,
                Values = new[] { (double)d.AuthorBooksCount }
            })
            .ToArray();
        pieChart1.Series = authorsSeries;
        pieChart1.LegendPosition = LiveChartsCore.Measure.LegendPosition.Right;
    }

    private void buttonExitBookStats_Click(object sender, EventArgs e)
    {
        Close();
    }
}