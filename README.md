# EdgeConnector

This EdgeConnector extends the QF EdgeConnector as documented in [QF readme](https://github.com/QuotationFactory/Integration.Quickstart/blob/master/README.md)

This is extended with the [Features.Graph.GraphConnector](./src/Integration.Host/Features/Graph/GraphConnector.cs) class to upload files to SharePointOnline

The **EdgeConnector** can be used for **uploading** files from the on-site factory to SharePointOnline.

For **downloading** from SharePointOnline, one could use **Azure Logic App** to trigger on a file created event in SharePointOnline and write file to Azure Blob storage, which is respectively synced via AzCopy back to factory on-site.

## WatchDirectory

If specified in the configuration, the `WatchDirectory` is used for configuring the directory to watch, i.e. `\\MyServer\MyFolder`
Similarly the `WatchFilter` is used to listen only to specific filetypes, i.e. `*.json`

## TargetDirectory

Files are uploaded online into `{TargetDirectory}` on the configured `DriveId`

Files are moved on-site into `{RootDirectory}\Output\Processed`
