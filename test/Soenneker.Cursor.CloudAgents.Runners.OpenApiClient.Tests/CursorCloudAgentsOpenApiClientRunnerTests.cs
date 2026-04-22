using Soenneker.Tests.HostedUnit;

namespace Soenneker.Cursor.CloudAgents.Runners.OpenApiClient.Tests;

[ClassDataSource<Host>(Shared = SharedType.PerTestSession)]
public sealed class CursorCloudAgentsOpenApiClientRunnerTests : HostedUnitTest
{
    public CursorCloudAgentsOpenApiClientRunnerTests(Host host) : base(host)
    {
    }

    [Test]
    public void Default()
    {

    }
}
