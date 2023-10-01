proc setupIgStyle() = 
  # 7787 style from ImThemes
  let style = igGetStyle()
  
  style.alpha = 1.0f
  style.disabledAlpha = 0.6000000238418579f
  style.windowPadding = ImVec2(x: 8.0f, y: 8.0f)
  style.windowRounding = 0.0f
  style.windowBorderSize = 1.0f
  style.windowMinSize = ImVec2(x: 32.0f, y: 32.0f)
  style.windowTitleAlign = ImVec2(x: 0.0f, y: 0.5f)
  style.windowMenuButtonPosition = ImGuiDir.Left
  style.childRounding = 0.0f
  style.childBorderSize = 1.0f
  style.popupRounding = 0.0f
  style.popupBorderSize = 1.0f
  style.framePadding = ImVec2(x: 8.899999618530273f, y: 6.400000095367432f)
  style.frameRounding = 0.0f
  style.frameBorderSize = 1.0f
  style.itemSpacing = ImVec2(x: 6.099999904632568f, y: 5.800000190734863f)
  style.itemInnerSpacing = ImVec2(x: 4.0f, y: 4.0f)
  style.cellPadding = ImVec2(x: 4.0f, y: 2.0f)
  style.indentSpacing = 21.0f
  style.columnsMinSpacing = 6.0f
  style.scrollbarSize = 14.0f
  style.scrollbarRounding = 9.0f
  style.grabMinSize = 10.0f
  style.grabRounding = 0.0f
  style.tabRounding = 0.0f
  style.tabBorderSize = 0.0f
  style.tabMinWidthForCloseButton = 0.0f
  style.colorButtonPosition = ImGuiDir.Right
  style.buttonTextAlign = ImVec2(x: 0.5f, y: 0.5f)
  style.selectableTextAlign = ImVec2(x: 0.0f, y: 0.0f)
  
  style.colors[ord ImGuiCol.Text] = ImVec4(x: 0.0f, y: 0.0f, z: 0.0f, w: 1.0f)
  style.colors[ord ImGuiCol.TextDisabled] = ImVec4(x: 0.6000000238418579f, y: 0.6000000238418579f, z: 0.6000000238418579f, w: 1.0f)
  style.colors[ord ImGuiCol.WindowBg] = ImVec4(x: 0.9372549057006836f, y: 0.9372549057006836f, z: 0.9372549057006836f, w: 1.0f)
  style.colors[ord ImGuiCol.ChildBg] = ImVec4(x: 0.0f, y: 0.0f, z: 0.0f, w: 0.0f)
  style.colors[ord ImGuiCol.PopupBg] = ImVec4(x: 1.0f, y: 1.0f, z: 1.0f, w: 0.9800000190734863f)
  style.colors[ord ImGuiCol.Border] = ImVec4(x: 9.999999974752427e-07f, y: 9.999899930335232e-07f, z: 9.999899930335232e-07f, w: 0.2360514998435974f)
  style.colors[ord ImGuiCol.BorderShadow] = ImVec4(x: 0.0f, y: 0.0f, z: 0.0f, w: 0.0f)
  style.colors[ord ImGuiCol.FrameBg] = ImVec4(x: 0.8240343332290649f, y: 0.8240261077880859f, z: 0.8240261077880859f, w: 1.0f)
  style.colors[ord ImGuiCol.FrameBgHovered] = ImVec4(x: 0.7338982224464417f, y: 0.7339018583297729f, z: 0.733905553817749f, w: 1.0f)
  style.colors[ord ImGuiCol.FrameBgActive] = ImVec4(x: 0.6480621695518494f, y: 0.6480653285980225f, z: 0.6480686664581299f, w: 1.0f)
  style.colors[ord ImGuiCol.TitleBg] = ImVec4(x: 0.7338982224464417f, y: 0.7339018583297729f, z: 0.733905553817749f, w: 1.0f)
  style.colors[ord ImGuiCol.TitleBgActive] = ImVec4(x: 0.8240343332290649f, y: 0.8240261077880859f, z: 0.8240261077880859f, w: 1.0f)
  style.colors[ord ImGuiCol.TitleBgCollapsed] = ImVec4(x: 1.0f, y: 1.0f, z: 1.0f, w: 1.0f)
  style.colors[ord ImGuiCol.MenuBarBg] = ImVec4(x: 0.8240343332290649f, y: 0.8240261077880859f, z: 0.8240261077880859f, w: 1.0f)
  style.colors[ord ImGuiCol.ScrollbarBg] = ImVec4(x: 0.9764705896377563f, y: 0.9764705896377563f, z: 0.9764705896377563f, w: 0.5299999713897705f)
  style.colors[ord ImGuiCol.ScrollbarGrab] = ImVec4(x: 0.686274528503418f, y: 0.686274528503418f, z: 0.686274528503418f, w: 0.800000011920929f)
  style.colors[ord ImGuiCol.ScrollbarGrabHovered] = ImVec4(x: 0.4862745106220245f, y: 0.4862745106220245f, z: 0.4862745106220245f, w: 0.800000011920929f)
  style.colors[ord ImGuiCol.ScrollbarGrabActive] = ImVec4(x: 0.4862745106220245f, y: 0.4862745106220245f, z: 0.4862745106220245f, w: 1.0f)
  style.colors[ord ImGuiCol.CheckMark] = ImVec4(x: 0.3690950274467468f, y: 0.3690968453884125f, z: 0.3690987229347229f, w: 1.0f)
  style.colors[ord ImGuiCol.SliderGrab] = ImVec4(x: 0.3690950274467468f, y: 0.3690968453884125f, z: 0.3690987229347229f, w: 1.0f)
  style.colors[ord ImGuiCol.SliderGrabActive] = ImVec4(x: 0.3690950274467468f, y: 0.3690968453884125f, z: 0.3690987229347229f, w: 1.0f)
  style.colors[ord ImGuiCol.Button] = ImVec4(x: 0.8240343332290649f, y: 0.8240261077880859f, z: 0.8240261077880859f, w: 1.0f)
  style.colors[ord ImGuiCol.ButtonHovered] = ImVec4(x: 0.7338982224464417f, y: 0.7339018583297729f, z: 0.733905553817749f, w: 1.0f)
  style.colors[ord ImGuiCol.ButtonActive] = ImVec4(x: 0.6480621695518494f, y: 0.6480653285980225f, z: 0.6480686664581299f, w: 1.0f)
  style.colors[ord ImGuiCol.Header] = ImVec4(x: 0.8240343332290649f, y: 0.8240261077880859f, z: 0.8240261077880859f, w: 1.0f)
  style.colors[ord ImGuiCol.HeaderHovered] = ImVec4(x: 0.7338982224464417f, y: 0.7339018583297729f, z: 0.733905553817749f, w: 1.0f)
  style.colors[ord ImGuiCol.HeaderActive] = ImVec4(x: 0.6480621695518494f, y: 0.6480653285980225f, z: 0.6480686664581299f, w: 1.0f)
  style.colors[ord ImGuiCol.Separator] = ImVec4(x: 0.6480621695518494f, y: 0.6480653285980225f, z: 0.6480686664581299f, w: 1.0f)
  style.colors[ord ImGuiCol.SeparatorHovered] = ImVec4(x: 0.1372549086809158f, y: 0.4392156898975372f, z: 0.800000011920929f, w: 0.7799999713897705f)
  style.colors[ord ImGuiCol.SeparatorActive] = ImVec4(x: 0.1372549086809158f, y: 0.4392156898975372f, z: 0.800000011920929f, w: 1.0f)
  style.colors[ord ImGuiCol.ResizeGrip] = ImVec4(x: 0.3490196168422699f, y: 0.3490196168422699f, z: 0.3490196168422699f, w: 0.1700000017881393f)
  style.colors[ord ImGuiCol.ResizeGripHovered] = ImVec4(x: 0.2588235437870026f, y: 0.5882353186607361f, z: 0.9764705896377563f, w: 0.6700000166893005f)
  style.colors[ord ImGuiCol.ResizeGripActive] = ImVec4(x: 0.2588235437870026f, y: 0.5882353186607361f, z: 0.9764705896377563f, w: 0.949999988079071f)
  style.colors[ord ImGuiCol.Tab] = ImVec4(x: 0.6480621695518494f, y: 0.6480653285980225f, z: 0.6480686664581299f, w: 1.0f)
  style.colors[ord ImGuiCol.TabHovered] = ImVec4(x: 0.7338982224464417f, y: 0.7339018583297729f, z: 0.733905553817749f, w: 1.0f)
  style.colors[ord ImGuiCol.TabActive] = ImVec4(x: 0.8240343332290649f, y: 0.8240261077880859f, z: 0.8240261077880859f, w: 1.0f)
  style.colors[ord ImGuiCol.TabUnfocused] = ImVec4(x: 0.9176470637321472f, y: 0.9254902005195618f, z: 0.9333333373069763f, w: 0.9861999750137329f)
  style.colors[ord ImGuiCol.TabUnfocusedActive] = ImVec4(x: 0.7411764860153198f, y: 0.8196078538894653f, z: 0.9137254953384399f, w: 1.0f)
  style.colors[ord ImGuiCol.PlotLines] = ImVec4(x: 0.3882353007793427f, y: 0.3882353007793427f, z: 0.3882353007793427f, w: 1.0f)
  style.colors[ord ImGuiCol.PlotLinesHovered] = ImVec4(x: 1.0f, y: 0.4274509847164154f, z: 0.3490196168422699f, w: 1.0f)
  style.colors[ord ImGuiCol.PlotHistogram] = ImVec4(x: 0.8980392217636108f, y: 0.6980392336845398f, z: 0.0f, w: 1.0f)
  style.colors[ord ImGuiCol.PlotHistogramHovered] = ImVec4(x: 1.0f, y: 0.4470588266849518f, z: 0.0f, w: 1.0f)
  style.colors[ord ImGuiCol.TableHeaderBg] = ImVec4(x: 0.7764706015586853f, y: 0.8666666746139526f, z: 0.9764705896377563f, w: 1.0f)
  style.colors[ord ImGuiCol.TableBorderStrong] = ImVec4(x: 0.5686274766921997f, y: 0.5686274766921997f, z: 0.6392157077789307f, w: 1.0f)
  style.colors[ord ImGuiCol.TableBorderLight] = ImVec4(x: 0.6784313917160034f, y: 0.6784313917160034f, z: 0.7372549176216125f, w: 1.0f)
  style.colors[ord ImGuiCol.TableRowBg] = ImVec4(x: 0.0f, y: 0.0f, z: 0.0f, w: 0.0f)
  style.colors[ord ImGuiCol.TableRowBgAlt] = ImVec4(x: 0.2980392277240753f, y: 0.2980392277240753f, z: 0.2980392277240753f, w: 0.09000000357627869f)
  style.colors[ord ImGuiCol.TextSelectedBg] = ImVec4(x: 0.2588235437870026f, y: 0.5882353186607361f, z: 0.9764705896377563f, w: 0.3499999940395355f)
  style.colors[ord ImGuiCol.DragDropTarget] = ImVec4(x: 0.2588235437870026f, y: 0.5882353186607361f, z: 0.9764705896377563f, w: 0.949999988079071f)
  style.colors[ord ImGuiCol.NavHighlight] = ImVec4(x: 0.2588235437870026f, y: 0.5882353186607361f, z: 0.9764705896377563f, w: 0.800000011920929f)
  style.colors[ord ImGuiCol.NavWindowingHighlight] = ImVec4(x: 0.6980392336845398f, y: 0.6980392336845398f, z: 0.6980392336845398f, w: 0.699999988079071f)
  style.colors[ord ImGuiCol.NavWindowingDimBg] = ImVec4(x: 0.2000000029802322f, y: 0.2000000029802322f, z: 0.2000000029802322f, w: 0.2000000029802322f)
  style.colors[ord ImGuiCol.ModalWindowDimBg] = ImVec4(x: 0.2000000029802322f, y: 0.2000000029802322f, z: 0.2000000029802322f, w: 0.3499999940395355f)