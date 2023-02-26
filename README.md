# ChroMapperPluginTemplates
ChroMapperのプラグイン作成用のVisualStudio用テンプレートです

Windows版のVisualStudio2022で動作確認済みです

ChroMapperプラグインの作成方法は[Wiki](https://github.com/rynan4818/ChroMapperPluginTemplates/wiki)に公式ドキュメントの日本語訳を置きましたので参考にしてください

## インストール方法

`(マイドキュメントフォルダ)\Visual Studio 2022\Templates\ProjectTemplates`に[Releases](https://github.com/rynan4818/ChroMapperPluginTemplates/releases)に添付している`ChroMapper-Plugin.*.zip`をコピーします。

## 使用方法
新しいプロジェクトの作成で、テンプレートの検索に`Chro`と入れるとテンプレートが出てきますので、それでプロジェクトを作成します。

[Releases](https://github.com/rynan4818/ChroMapperPluginTemplates/releases)に添付している`ProjectName.csproj.user`をプロジェクトフォルダ(.csprojがあるフォルダ)にコピーして、`ProjectName`をプロジェクト名にリネームします。

以下の`<ChroMapperDir>`の項目をChroMapperのインストールパスに修正してください。
```
<?xml version="1.0" encoding="utf-8"?>
<Project ToolsVersion="Current" xmlns="http://schemas.microsoft.com/developer/msbuild/2003">
	<PropertyGroup>
		<ChroMapperDir>C:\TOOL\ChroMapper\chromapper</ChroMapperDir> ←★ここを変更★
		<ReferencePath>$(ChroMapperDir)\ChroMapper_Data\Managed;$(ChroMapperDir)\Plugins</ReferencePath>
	</PropertyGroup>
</Project>
```

ビルドイベントに以下のバッチが設定してあります
- ChroMapperのPluginフォルダにビルドしたプラグインのDLLをコピー
- Releaseビルド時に`ReleasesArchives`フォルダを作成してzip圧縮
    `ReleasesArchives\Release`フォルダにREADMEとか入れておくと一緒にzip圧縮します

Git管理する場合は`ReleasesArchives`のDLLとzipを除外するために`.gitignore`に以下を追加してください
```
プロジェクト名-*.zip
プロジェクト名*.dll
```

## 各テンプレートの説明
- ChroMapper-Plugin(Core) : 最小限の構成です
- ChroMapper-Plugin(Option) : Coreに設定ファイル用のOprion.csを追加
- ChroMapper-Plugin(OptionHarmony) : OptionにHarmonyを追加
