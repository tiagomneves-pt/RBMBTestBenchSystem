using RBMBTestBenchSystem.Data;

namespace RBMBTestBenchSystem.Components.Pages;

public partial class DatabaseViewer
{
    public bool ShowCreate { get; set; }
    public Bearing? NewBearing { get; set; }


    //This method initializes the page with the pop-up hidden
    protected override async Task OnInitializedAsync()
    {
        ShowCreate = false;
    }
    
    private DataContext? _context;
    
    public void ShowCreateForm()
    {
        NewBearing = new Bearing();
        ShowCreate = true;

        public async Task CreateNewBearing();
        
        _context ??= await BearingDataContextFactory.CreateDbContextAsync();

    }
}
