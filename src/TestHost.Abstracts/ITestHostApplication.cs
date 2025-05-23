
using Microsoft.Extensions.Hosting;

namespace TestHost.Abstracts;

/// <summary>
/// An interface for a hosting a test application.
/// </summary>
public interface ITestHostApplication : IAsyncDisposable
{
    /// <summary>
    /// Gets the host for the tests.
    /// </summary>
    /// <value>
    /// The host for the tests.
    /// </value>
    IHost Host { get; }

    /// <summary>
    /// Gets the services configured for this test host.
    /// </summary>
    /// <value>
    /// The services configured for this test host.
    /// </value>
    IServiceProvider Services { get; }
}
