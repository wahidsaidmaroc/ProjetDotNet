using BenchmarkDotNet.Attributes;
using EF9SQLite.DB;
using Microsoft.EntityFrameworkCore;
namespace EF9SQLite;


[MemoryDiagnoser]
public class EfBenchmarks
{
    private AppDbContext _context = null!;

    [GlobalSetup]
    public void Setup()
    {
        _context = new AppDbContext();
        _context.Database.OpenConnection();
        _context.Database.EnsureCreated();
    }

    [Benchmark]
    public List<Client> WithTracking()
    {
        return _context.Clients.ToList();
    }

    [Benchmark]
    public List<Client> WithoutTracking()
    {
        return _context.Clients.AsNoTracking().ToList();
    }

    [GlobalCleanup]
    public void Cleanup() => _context.Dispose();
}
