# Publishing checklist

From "Use this template" to being listed on the Community Stride Asset Store:

1. **Rename everything.** `StrideAssetTemplate` → your asset name: the `AssetData/<Project>/` folder,
   the `.csproj` (+ `RootNamespace`/`AssemblyName`), the `.sln`, and the component reference inside
   `Demo/Assets/MainScene.sdscene` (`!StrideAssetTemplate.ExampleScript,StrideAssetTemplate`).
2. **Write your code** in `AssetData/<Project>/`. Only `AssetData/` is installed into user
   projects — the demo, media and docs stay behind. Keep NuGet dependencies minimal: your source
   is compiled inside your users' games.
3. **Fill `AssetData/manifest.json`.** `id` is reverse-DNS (`com.yourname.your-asset`);
   `category` and `license` must exist in the registry's
   [catalog](https://github.com/Nicogo1705/AssetContainer/tree/main/catalog). Tags are displayed
   on your card and searchable — pick words users would type.
4. **Replace `thumbnail.png`** (~512×512 — it's your storefront card and your link previews).
5. **Add media** to `media/` and list them in the manifest — see [media/GUIDE.md](media/GUIDE.md).
   The **first animated file (gif/mp4) plays on card hover** in the store: lead with your best.
6. **Rewrite `README.md`** (pitch, GIF, what's in the box, quick start, API, performance, demo)
   and put your name in `LICENSE.md`.
7. **Make the demo show off the asset** — `Demo` is what reviewers launch first, and what the
   store offers your users in one click. It is a single project that runs on Windows, Linux and
   macOS (`dotnet run` from the `Demo` folder), so keep it that way: no per-platform head, and no
   Stride package version the rest of the asset does not use.
8. **Submit**: open a PR adding `registry/<your-id>.json` to
   [AssetContainer](https://github.com/Nicogo1705/AssetContainer) — start from
   [`registry-entry.example.json`](registry-entry.example.json) — or use the desktop app's
   publish wizard which does it for you. CI validates the schema, clones your repo, checks the
   content hash and detects the Stride version; results are posted on the PR.
9. **After merging**, your asset appears in the store on the next index build. Want the
   ✔ certified badge on a version? Tag a release and ask for certification in the PR.
