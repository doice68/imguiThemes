public static void SetupImGuiStyle()
{
	// bluer style from ImThemes
	var style = ImGuiNET.ImGui.GetStyle();
	
	style.Alpha = 1.0f;
	style.DisabledAlpha = 0.6000000238418579f;
	style.WindowPadding = new Vector2(8.0f, 8.0f);
	style.WindowRounding = 5.0f;
	style.WindowBorderSize = 1.0f;
	style.WindowMinSize = new Vector2(32.0f, 32.0f);
	style.WindowTitleAlign = new Vector2(0.5f, 0.5f);
	style.WindowMenuButtonPosition = ImGuiDir.Left;
	style.ChildRounding = 5.0f;
	style.ChildBorderSize = 1.0f;
	style.PopupRounding = 3.0f;
	style.PopupBorderSize = 1.0f;
	style.FramePadding = new Vector2(14.5f, 5.099999904632568f);
	style.FrameRounding = 3.0f;
	style.FrameBorderSize = 1.0f;
	style.ItemSpacing = new Vector2(5.0f, 5.0f);
	style.ItemInnerSpacing = new Vector2(4.0f, 4.0f);
	style.CellPadding = new Vector2(4.0f, 2.0f);
	style.IndentSpacing = 21.0f;
	style.ColumnsMinSpacing = 6.0f;
	style.ScrollbarSize = 14.0f;
	style.ScrollbarRounding = 0.0f;
	style.GrabMinSize = 10.0f;
	style.GrabRounding = 0.0f;
	style.TabRounding = 3.0f;
	style.TabBorderSize = 0.0f;
	style.TabMinWidthForCloseButton = 0.0f;
	style.ColorButtonPosition = ImGuiDir.Right;
	style.ButtonTextAlign = new Vector2(0.5f, 0.5f);
	style.SelectableTextAlign = new Vector2(0.0f, 0.0f);
	
	style.Colors[(int)ImGuiCol.Text] = new Vector4(0.9999899864196777f, 0.9999926686286926f, 1.0f, 1.0f);
	style.Colors[(int)ImGuiCol.TextDisabled] = new Vector4(0.4198640584945679f, 0.4198683500289917f, 0.5622317790985107f, 1.0f);
	style.Colors[(int)ImGuiCol.WindowBg] = new Vector4(0.062745101749897f, 0.06666667014360428f, 0.08627451211214066f, 1.0f);
	style.Colors[(int)ImGuiCol.ChildBg] = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
	style.Colors[(int)ImGuiCol.PopupBg] = new Vector4(0.062745101749897f, 0.06666667014360428f, 0.08627451211214066f, 0.9055793881416321f);
	style.Colors[(int)ImGuiCol.Border] = new Vector4(0.6411612033843994f, 0.7408788204193115f, 0.9828326106071472f, 0.1587982773780823f);
	style.Colors[(int)ImGuiCol.BorderShadow] = new Vector4(0.9999899864196777f, 0.9999905824661255f, 1.0f, 0.0f);
	style.Colors[(int)ImGuiCol.FrameBg] = new Vector4(0.1215686276555061f, 0.1215686276555061f, 0.1529411822557449f, 1.0f);
	style.Colors[(int)ImGuiCol.FrameBgHovered] = new Vector4(0.02127504721283913f, 0.2217375934123993f, 0.7081544995307922f, 1.0f);
	style.Colors[(int)ImGuiCol.FrameBgActive] = new Vector4(0.02608264423906803f, 0.3724088966846466f, 0.7596566677093506f, 1.0f);
	style.Colors[(int)ImGuiCol.TitleBg] = new Vector4(0.1215686276555061f, 0.1215686276555061f, 0.1529411822557449f, 1.0f);
	style.Colors[(int)ImGuiCol.TitleBgActive] = new Vector4(0.1215686276555061f, 0.1215686276555061f, 0.1529411822557449f, 1.0f);
	style.Colors[(int)ImGuiCol.TitleBgCollapsed] = new Vector4(0.1215686276555061f, 0.1215686276555061f, 0.1529411822557449f, 1.0f);
	style.Colors[(int)ImGuiCol.MenuBarBg] = new Vector4(0.062745101749897f, 0.06666667014360428f, 0.08627451211214066f, 1.0f);
	style.Colors[(int)ImGuiCol.ScrollbarBg] = new Vector4(0.01960784383118153f, 0.01960784383118153f, 0.01960784383118153f, 0.5299999713897705f);
	style.Colors[(int)ImGuiCol.ScrollbarGrab] = new Vector4(0.08627451211214066f, 0.08627451211214066f, 0.1176470592617989f, 1.0f);
	style.Colors[(int)ImGuiCol.ScrollbarGrabHovered] = new Vector4(0.02372493036091328f, 0.2528279423713684f, 0.6909871101379395f, 1.0f);
	style.Colors[(int)ImGuiCol.ScrollbarGrabActive] = new Vector4(0.06354876607656479f, 0.499586433172226f, 0.9871244430541992f, 1.0f);
	style.Colors[(int)ImGuiCol.CheckMark] = new Vector4(0.1115880012512207f, 0.6225316524505615f, 1.0f, 1.0f);
	style.Colors[(int)ImGuiCol.SliderGrab] = new Vector4(0.1115880012512207f, 0.6225316524505615f, 1.0f, 1.0f);
	style.Colors[(int)ImGuiCol.SliderGrabActive] = new Vector4(0.1115880012512207f, 0.6225316524505615f, 1.0f, 1.0f);
	style.Colors[(int)ImGuiCol.Button] = new Vector4(0.0f, 0.35061115026474f, 0.7424892783164978f, 1.0f);
	style.Colors[(int)ImGuiCol.ButtonHovered] = new Vector4(0.02372493036091328f, 0.2528279423713684f, 0.6909871101379395f, 1.0f);
	style.Colors[(int)ImGuiCol.ButtonActive] = new Vector4(0.02127504721283913f, 0.2217375934123993f, 0.7081544995307922f, 1.0f);
	style.Colors[(int)ImGuiCol.Header] = new Vector4(0.02608264423906803f, 0.3724088966846466f, 0.7596566677093506f, 1.0f);
	style.Colors[(int)ImGuiCol.HeaderHovered] = new Vector4(0.02127504721283913f, 0.2217375934123993f, 0.7081544995307922f, 1.0f);
	style.Colors[(int)ImGuiCol.HeaderActive] = new Vector4(0.02608264423906803f, 0.3724088966846466f, 0.7596566677093506f, 1.0f);
	style.Colors[(int)ImGuiCol.Separator] = new Vector4(0.02127504721283913f, 0.2217375934123993f, 0.7081544995307922f, 1.0f);
	style.Colors[(int)ImGuiCol.SeparatorHovered] = new Vector4(0.02372493036091328f, 0.2528279423713684f, 0.6909871101379395f, 1.0f);
	style.Colors[(int)ImGuiCol.SeparatorActive] = new Vector4(0.02608264423906803f, 0.3724088966846466f, 0.7596566677093506f, 1.0f);
	style.Colors[(int)ImGuiCol.ResizeGrip] = new Vector4(0.2082189917564392f, 0.208219513297081f, 0.3090128898620605f, 1.0f);
	style.Colors[(int)ImGuiCol.ResizeGripHovered] = new Vector4(0.02608264423906803f, 0.3724088966846466f, 0.7596566677093506f, 1.0f);
	style.Colors[(int)ImGuiCol.ResizeGripActive] = new Vector4(0.02608264423906803f, 0.3724088966846466f, 0.7596566677093506f, 1.0f);
	style.Colors[(int)ImGuiCol.Tab] = new Vector4(0.02372493036091328f, 0.2528279423713684f, 0.6909871101379395f, 1.0f);
	style.Colors[(int)ImGuiCol.TabHovered] = new Vector4(0.02608264423906803f, 0.3724088966846466f, 0.7596566677093506f, 1.0f);
	style.Colors[(int)ImGuiCol.TabActive] = new Vector4(0.05124427750706673f, 0.4829885959625244f, 0.9184549450874329f, 1.0f);
	style.Colors[(int)ImGuiCol.TabUnfocused] = new Vector4(0.02372493036091328f, 0.2528279423713684f, 0.6909871101379395f, 1.0f);
	style.Colors[(int)ImGuiCol.TabUnfocusedActive] = new Vector4(0.05124427750706673f, 0.4829885959625244f, 0.9184549450874329f, 1.0f);
	style.Colors[(int)ImGuiCol.PlotLines] = new Vector4(0.02608264423906803f, 0.3724088966846466f, 0.7596566677093506f, 1.0f);
	style.Colors[(int)ImGuiCol.PlotLinesHovered] = new Vector4(0.1098039224743843f, 0.6235294342041016f, 1.0f, 1.0f);
	style.Colors[(int)ImGuiCol.PlotHistogram] = new Vector4(0.02608264423906803f, 0.3724088966846466f, 0.7596566677093506f, 1.0f);
	style.Colors[(int)ImGuiCol.PlotHistogramHovered] = new Vector4(0.1098039224743843f, 0.6235294342041016f, 1.0f, 1.0f);
	style.Colors[(int)ImGuiCol.TableHeaderBg] = new Vector4(0.1882352977991104f, 0.1882352977991104f, 0.2000000029802322f, 1.0f);
	style.Colors[(int)ImGuiCol.TableBorderStrong] = new Vector4(0.3098039329051971f, 0.3098039329051971f, 0.3490196168422699f, 1.0f);
	style.Colors[(int)ImGuiCol.TableBorderLight] = new Vector4(0.2274509817361832f, 0.2274509817361832f, 0.2470588237047195f, 1.0f);
	style.Colors[(int)ImGuiCol.TableRowBg] = new Vector4(0.0f, 0.0f, 0.0f, 0.0f);
	style.Colors[(int)ImGuiCol.TableRowBgAlt] = new Vector4(1.0f, 1.0f, 1.0f, 0.05999999865889549f);
	style.Colors[(int)ImGuiCol.TextSelectedBg] = new Vector4(0.02608264423906803f, 0.3724088966846466f, 0.7596566677093506f, 1.0f);
	style.Colors[(int)ImGuiCol.DragDropTarget] = new Vector4(0.06354876607656479f, 0.499586433172226f, 0.9871244430541992f, 1.0f);
	style.Colors[(int)ImGuiCol.NavHighlight] = new Vector4(0.06354876607656479f, 0.499586433172226f, 0.9871244430541992f, 1.0f);
	style.Colors[(int)ImGuiCol.NavWindowingHighlight] = new Vector4(1.0f, 1.0f, 1.0f, 0.699999988079071f);
	style.Colors[(int)ImGuiCol.NavWindowingDimBg] = new Vector4(0.800000011920929f, 0.800000011920929f, 0.800000011920929f, 0.2000000029802322f);
	style.Colors[(int)ImGuiCol.ModalWindowDimBg] = new Vector4(0.800000011920929f, 0.800000011920929f, 0.800000011920929f, 0.3499999940395355f);
}