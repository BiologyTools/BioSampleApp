run("Bio-Formats Importer", "open=" + getArgument + " autoscale color_mode=Default open_all_series display_metadata display_rois rois_import=[ROI manager] view=Hyperstack stack_order=XYCZT");
run("Bio-Formats Exporter", "save=F:/TESTIMAGES/CZI/16Bit-ZStack.ome.tif export compression=Uncompressed");
dir = getDir("startup");
File.saveString("done",dir + "/done.txt");
