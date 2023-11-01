using Microsoft.Playwright;

public static class PlaywrightPageExtension
{
    public static async Task<IEnumerable<IElementHandle>> PickAllAsync(this IPage page, string dataTestId)
    {
        var elements = await page.QuerySelectorAllAsync($"[data-test='{dataTestId}']");
        return elements;
    }
}