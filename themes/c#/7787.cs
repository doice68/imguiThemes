public static void SetupImGuiStyle()
{
	// 7787 style from ImThemes
	var style = ImGuiNET.ImGui.GetStyle();
	
	style.Alpha = 1.0f;
	style.DisabledAlpha = 0.6000000238418579f;
	style.WindowPadding = new Vector2(8.0f, 8.0f);
	style.WindowRounding = 0.0f;
	style.WindowBorderSize = 1.0f;
	style.WindowMinSize = new Vector2(32.0f, 32.0f);
	style.WindowTitleAlign = new Vector2(0.0f, 0.5f);
	style.WindowMenuButtonPosition = ImGuiDir.Left;
	style.ChildRounding = 0.0f;
	style.ChildBorderSize = 1.0f;
	style.PopupRounding = 0.0f;
	style.PopupBorderSize = 1.0f;
	style.FramePadding = new Vector2(8.899999618530273f, 6.400000095367432f);
	style.FrameRounding = 0.0f;
	style.FrameBorderSize = 1.0f;
	style.ItemSpacing = new Vector2(6.099999904632568f, 5.800000190734863f);
	style.ItemInnerSpacing = new Vector2(4.0f, 4.0f);
	style.CellPadding = new Vector2(4.0f, 2.0f);
	style.IndentSpacing = 21.0f;
	style.ColumnsMinSpacing = 6.0f;
	style.ScrollbarSize = 14.0f;
	style.ScrollbarRounding = 9.0f;
	style.GrabMinSize = 10.0f;
	style.GrabRounding = 0.0f;
	style.TabRounding = 0.0f;
	style.TabBorderSize = 0.0f;
	style.TabMinWidthForCloseButton = 0.0f;
	style.ColorButtonPosition = ImGuiDir.Right;
	style.ButtonTextAlign = new Vector2(0.5f, 0.5f);
	style.SelectableTextAlign = new Vector2(0.0f, 0.0f);
	
	style.Colors[(int)ImGuiCol.Text] = new Vector4(0.0f, 0.0f, 0.0f, 1.0f);
	style.Colors[(int)ImGuiCol.TextDisabled] = new Vector4(0.6000000238418579f, 0.6000000238418579f, 0.6000000238418579f, 1.0f);
	style.Colors[(int)ImGuiCol.WindowBg] = new Vector4(0.9372549057006836f, 0.9372549057006836f, 0.9372549057006836f, 1.0f);
	style.Colors[(int)ImGuiCol.ChildBg] = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
	style.Colors[(int)ImGuiCol.PopupBg] = new Vector4(1.0f, 1.0f, 1.0f, 0.9800000190734863f);
	style.Colors[(int)ImGuiCol.Border] = new Vector4(9.999999974752427e-07f, 9.999899930335232e-07f, 9.999899930335232e-07f, 0.2360514998435974f);
	style.Colors[(int)ImGuiCol.BorderShadow] = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
	style.Colors[(int)ImGuiCol.FrameBg] = new Vector4(0.8240343332290649f, 0.8240261077880859f, 0.8240261077880859f, 1.0f);
	style.Colors[(int)ImGuiCol.FrameBgHovered] = new Vector4(0.7338982224464417f, 0.7339018583297729f, 0.733905553817749f, 1.0f);
	style.Colors[(int)ImGuiCol.FrameBgActive] = new Vector4(0.6480621695518494f, 0.6480653285980225f, 0.6480686664581299f, 1.0f);
	style.Colors[(int)ImGuiCol.TitleBg] = new Vector4(0.7338982224464417f, 0.7339018583297729f, 0.733905553817749f, 1.0f);
	style.Colors[(int)ImGuiCol.TitleBgActive] = new Vector4(0.8240343332290649f, 0.8240261077880859f, 0.8240261077880859f, 1.0f);
	style.Colors[(int)ImGuiCol.TitleBgCollapsed] = new Vector4(1.0f, 1.0f, 1.0f, 1.0f);
	style.Colors[(int)ImGuiCol.MenuBarBg] = new Vector4(0.8240343332290649f, 0.8240261077880859f, 0.8240261077880859f, 1.0f);
	style.Colors[(int)ImGuiCol.ScrollbarBg] = new Vector4(0.9764705896377563f, 0.9764705896377563f, 0.9764705896377563f, 0.5299999713897705f);
	style.Colors[(int)ImGuiCol.ScrollbarGrab] = new Vector4(0.686274528503418f, 0.686274528503418f, 0.686274528503418f, 0.800000011920929f);
	style.Colors[(int)ImGuiCol.ScrollbarGrabHovered] = new Vector4(0.4862745106220245f, 0.4862745106220245f, 0.4862745106220245f, 0.800000011920929f);
	style.Colors[(int)ImGuiCol.ScrollbarGrabActive] = new Vector4(0.4862745106220245f, 0.4862745106220245f, 0.4862745106220245f, 1.0f);
	style.Colors[(int)ImGuiCol.CheckMark] = new Vector4(0.3690950274467468f, 0.3690968453884125f, 0.3690987229347229f, 1.0f);
	style.Colors[(int)ImGuiCol.SliderGrab] = new Vector4(0.3690950274467468f, 0.3690968453884125f, 0.3690987229347229f, 1.0f);
	style.Colors[(int)ImGuiCol.SliderGrabActive] = new Vector4(0.3690950274467468f, 0.3690968453884125f, 0.3690987229347229f, 1.0f);
	style.Colors[(int)ImGuiCol.Button] = new Vector4(0.8240343332290649f, 0.8240261077880859f, 0.8240261077880859f, 1.0f);
	style.Colors[(int)ImGuiCol.ButtonHovered] = new Vector4(0.7338982224464417f, 0.7339018583297729f, 0.733905553817749f, 1.0f);
	style.Colors[(int)ImGuiCol.ButtonActive] = new Vector4(0.6480621695518494f, 0.6480653285980225f, 0.6480686664581299f, 1.0f);
	style.Colors[(int)ImGuiCol.Header] = new Vector4(0.8240343332290649f, 0.8240261077880859f, 0.8240261077880859f, 1.0f);
	style.Colors[(int)ImGuiCol.HeaderHovered] = new Vector4(0.7338982224464417f, 0.7339018583297729f, 0.733905553817749f, 1.0f);
	style.Colors[(int)ImGuiCol.HeaderActive] = new Vector4(0.6480621695518494f, 0.6480653285980225f, 0.6480686664581299f, 1.0f);
	style.Colors[(int)ImGuiCol.Separator] = new Vector4(0.6480621695518494f, 0.6480653285980225f, 0.6480686664581299f, 1.0f);
	style.Colors[(int)ImGuiCol.SeparatorHovered] = new Vector4(0.1372549086809158f, 0.4392156898975372f, 0.800000011920929f, 0.7799999713897705f);
	style.Colors[(int)ImGuiCol.SeparatorActive] = new Vector4(0.1372549086809158f, 0.4392156898975372f, 0.800000011920929f, 1.0f);
	style.Colors[(int)ImGuiCol.ResizeGrip] = new Vector4(0.3490196168422699f, 0.3490196168422699f, 0.3490196168422699f, 0.1700000017881393f);
	style.Colors[(int)ImGuiCol.ResizeGripHovered] = new Vector4(0.2588235437870026f, 0.5882353186607361f, 0.9764705896377563f, 0.6700000166893005f);
	style.Colors[(int)ImGuiCol.ResizeGripActive] = new Vector4(0.2588235437870026f, 0.5882353186607361f, 0.9764705896377563f, 0.949999988079071f);
	style.Colors[(int)ImGuiCol.Tab] = new Vector4(0.6480621695518494f, 0.6480653285980225f, 0.6480686664581299f, 1.0f);
	style.Colors[(int)ImGuiCol.TabHovered] = new Vector4(0.7338982224464417f, 0.7339018583297729f, 0.733905553817749f, 1.0f);
	style.Colors[(int)ImGuiCol.TabActive] = new Vector4(0.8240343332290649f, 0.8240261077880859f, 0.8240261077880859f, 1.0f);
	style.Colors[(int)ImGuiCol.TabUnfocused] = new Vector4(0.9176470637321472f, 0.9254902005195618f, 0.9333333373069763f, 0.9861999750137329f);
	style.Colors[(int)ImGuiCol.TabUnfocusedActive] = new Vector4(0.7411764860153198f, 0.8196078538894653f, 0.9137254953384399f, 1.0f);
	style.Colors[(int)ImGuiCol.PlotLines] = new Vector4(0.3882353007793427f, 0.3882353007793427f, 0.3882353007793427f, 1.0f);
	style.Colors[(int)ImGuiCol.PlotLinesHovered] = new Vector4(1.0f, 0.4274509847164154f, 0.3490196168422699f, 1.0f);
	style.Colors[(int)ImGuiCol.PlotHistogram] = new Vector4(0.8980392217636108f, 0.6980392336845398f, 0.0f, 1.0f);
	style.Colors[(int)ImGuiCol.PlotHistogramHovered] = new Vector4(1.0f, 0.4470588266849518f, 0.0f, 1.0f);
	style.Colors[(int)ImGuiCol.TableHeaderBg] = new Vector4(0.7764706015586853f, 0.8666666746139526f, 0.9764705896377563f, 1.0f);
	style.Colors[(int)ImGuiCol.TableBorderStrong] = new Vector4(0.5686274766921997f, 0.5686274766921997f, 0.6392157077789307f, 1.0f);
	style.Colors[(int)ImGuiCol.TableBorderLight] = new Vector4(0.6784313917160034f, 0.6784313917160034f, 0.7372549176216125f, 1.0f);
	style.Colors[(int)ImGuiCol.TableRowBg] = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
	style.Colors[(int)ImGuiCol.TableRowBgAlt] = new Vector4(0.2980392277240753f, 0.2980392277240753f, 0.2980392277240753f, 0.09000000357627869f);
	style.Colors[(int)ImGuiCol.TextSelectedBg] = new Vector4(0.2588235437870026f, 0.5882353186607361f, 0.9764705896377563f, 0.3499999940395355f);
	style.Colors[(int)ImGuiCol.DragDropTarget] = new Vector4(0.2588235437870026f, 0.5882353186607361f, 0.9764705896377563f, 0.949999988079071f);
	style.Colors[(int)ImGuiCol.NavHighlight] = new Vector4(0.2588235437870026f, 0.5882353186607361f, 0.9764705896377563f, 0.800000011920929f);
	style.Colors[(int)ImGuiCol.NavWindowingHighlight] = new Vector4(0.6980392336845398f, 0.6980392336845398f, 0.6980392336845398f, 0.699999988079071f);
	style.Colors[(int)ImGuiCol.NavWindowingDimBg] = new Vector4(0.2000000029802322f, 0.2000000029802322f, 0.2000000029802322f, 0.2000000029802322f);
	style.Colors[(int)ImGuiCol.ModalWindowDimBg] = new Vector4(0.2000000029802322f, 0.2000000029802322f, 0.2000000029802322f, 0.3499999940395355f);
}