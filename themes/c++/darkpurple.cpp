void SetupImGuiStyle()
{
	// DarkPurple style from ImThemes
	ImGuiStyle& style = ImGui::GetStyle();
	
	style.Alpha = 1.0f;
	style.DisabledAlpha = 0.300000011920929f;
	style.WindowPadding = ImVec2(8.399999618530273f, 8.0f);
	style.WindowRounding = 0.0f;
	style.WindowBorderSize = 0.0f;
	style.WindowMinSize = ImVec2(32.0f, 32.0f);
	style.WindowTitleAlign = ImVec2(0.0f, 0.5f);
	style.WindowMenuButtonPosition = ImGuiDir_Left;
	style.ChildRounding = 6.5f;
	style.ChildBorderSize = 1.0f;
	style.PopupRounding = 0.0f;
	style.PopupBorderSize = 0.0f;
	style.FramePadding = ImVec2(20.0f, 5.900000095367432f);
	style.FrameRounding = 5.0f;
	style.FrameBorderSize = 0.0f;
	style.ItemSpacing = ImVec2(3.799999952316284f, 4.599999904632568f);
	style.ItemInnerSpacing = ImVec2(4.0f, 4.0f);
	style.CellPadding = ImVec2(6.5f, 2.0f);
	style.IndentSpacing = 21.0f;
	style.ColumnsMinSpacing = 6.0f;
	style.ScrollbarSize = 20.0f;
	style.ScrollbarRounding = 3.099999904632568f;
	style.GrabMinSize = 10.60000038146973f;
	style.GrabRounding = 2.599999904632568f;
	style.TabRounding = 8.100000381469727f;
	style.TabBorderSize = 0.0f;
	style.TabMinWidthForCloseButton = 0.0f;
	style.ColorButtonPosition = ImGuiDir_Right;
	style.ButtonTextAlign = ImVec2(0.5f, 0.5f);
	style.SelectableTextAlign = ImVec2(0.0f, 0.0f);
	
	style.Colors[ImGuiCol_Text] = ImVec4(1.0f, 1.0f, 1.0f, 1.0f);
	style.Colors[ImGuiCol_TextDisabled] = ImVec4(0.4980392158031464f, 0.4980392158031464f, 0.4980392158031464f, 1.0f);
	style.Colors[ImGuiCol_WindowBg] = ImVec4(9.999899930335232e-07f, 9.999919257097645e-07f, 9.999999974752427e-07f, 1.0f);
	style.Colors[ImGuiCol_ChildBg] = ImVec4(0.0f, 0.0f, 0.0f, 0.0f);
	style.Colors[ImGuiCol_PopupBg] = ImVec4(9.999999974752427e-07f, 9.999899930335232e-07f, 9.999899930335232e-07f, 1.0f);
	style.Colors[ImGuiCol_Border] = ImVec4(0.06089630350470543f, 0.0663527324795723f, 0.1244634985923767f, 1.0f);
	style.Colors[ImGuiCol_BorderShadow] = ImVec4(0.0f, 0.0f, 0.0f, 0.0f);
	style.Colors[ImGuiCol_FrameBg] = ImVec4(0.2745098173618317f, 0.125490203499794f, 0.8039215803146362f, 0.3175965547561646f);
	style.Colors[ImGuiCol_FrameBgHovered] = ImVec4(0.4235294163227081f, 0.2196078449487686f, 0.9647058844566345f, 0.3176470696926117f);
	style.Colors[ImGuiCol_FrameBgActive] = ImVec4(0.2745098173618317f, 0.125490203499794f, 0.8039215803146362f, 0.7682403326034546f);
	style.Colors[ImGuiCol_TitleBg] = ImVec4(0.03921568766236305f, 0.03921568766236305f, 0.03921568766236305f, 1.0f);
	style.Colors[ImGuiCol_TitleBgActive] = ImVec4(9.999999974752427e-07f, 9.999899930335232e-07f, 9.999946541938698e-07f, 1.0f);
	style.Colors[ImGuiCol_TitleBgCollapsed] = ImVec4(9.999999974752427e-07f, 9.999899930335232e-07f, 9.999899930335232e-07f, 1.0f);
	style.Colors[ImGuiCol_MenuBarBg] = ImVec4(9.999999974752427e-07f, 9.999899930335232e-07f, 9.999960184359225e-07f, 1.0f);
	style.Colors[ImGuiCol_ScrollbarBg] = ImVec4(0.06089630350470543f, 0.0663527324795723f, 0.1244634985923767f, 1.0f);
	style.Colors[ImGuiCol_ScrollbarGrab] = ImVec4(0.2745098173618317f, 0.125490203499794f, 0.8039215803146362f, 1.0f);
	style.Colors[ImGuiCol_ScrollbarGrabHovered] = ImVec4(0.4235294163227081f, 0.2196078449487686f, 0.9647058844566345f, 1.0f);
	style.Colors[ImGuiCol_ScrollbarGrabActive] = ImVec4(0.2745098173618317f, 0.125490203499794f, 0.8039215803146362f, 1.0f);
	style.Colors[ImGuiCol_CheckMark] = ImVec4(0.4235294163227081f, 0.2196078449487686f, 0.9647058844566345f, 1.0f);
	style.Colors[ImGuiCol_SliderGrab] = ImVec4(0.407843142747879f, 0.3098039329051971f, 1.0f, 1.0f);
	style.Colors[ImGuiCol_SliderGrabActive] = ImVec4(0.4235294163227081f, 0.2196078449487686f, 0.9647058844566345f, 1.0f);
	style.Colors[ImGuiCol_Button] = ImVec4(0.2745098173618317f, 0.125490203499794f, 0.8039215803146362f, 1.0f);
	style.Colors[ImGuiCol_ButtonHovered] = ImVec4(0.4235294163227081f, 0.2196078449487686f, 0.9647058844566345f, 1.0f);
	style.Colors[ImGuiCol_ButtonActive] = ImVec4(0.2745098173618317f, 0.125490203499794f, 0.8039215803146362f, 1.0f);
	style.Colors[ImGuiCol_Header] = ImVec4(0.2745098173618317f, 0.125490203499794f, 0.8039215803146362f, 1.0f);
	style.Colors[ImGuiCol_HeaderHovered] = ImVec4(0.4235294163227081f, 0.2196078449487686f, 0.9647058844566345f, 1.0f);
	style.Colors[ImGuiCol_HeaderActive] = ImVec4(0.2745098173618317f, 0.125490203499794f, 0.8039215803146362f, 1.0f);
	style.Colors[ImGuiCol_Separator] = ImVec4(0.09442061185836792f, 0.09441966563463211f, 0.09442023187875748f, 1.0f);
	style.Colors[ImGuiCol_SeparatorHovered] = ImVec4(0.09442061185836792f, 0.09441966563463211f, 0.09442023187875748f, 1.0f);
	style.Colors[ImGuiCol_SeparatorActive] = ImVec4(0.09442061185836792f, 0.09441966563463211f, 0.09442023187875748f, 1.0f);
	style.Colors[ImGuiCol_ResizeGrip] = ImVec4(0.2745098173618317f, 0.125490203499794f, 0.8039215803146362f, 1.0f);
	style.Colors[ImGuiCol_ResizeGripHovered] = ImVec4(0.4245694577693939f, 0.2196577787399292f, 0.9656652212142944f, 1.0f);
	style.Colors[ImGuiCol_ResizeGripActive] = ImVec4(0.2745098173618317f, 0.125490203499794f, 0.8039215803146362f, 1.0f);
	style.Colors[ImGuiCol_Tab] = ImVec4(0.2745098173618317f, 0.125490203499794f, 0.8039215803146362f, 1.0f);
	style.Colors[ImGuiCol_TabHovered] = ImVec4(0.4245694577693939f, 0.2196577787399292f, 0.9656652212142944f, 1.0f);
	style.Colors[ImGuiCol_TabActive] = ImVec4(0.4245694577693939f, 0.2196577787399292f, 0.9656652212142944f, 1.0f);
	style.Colors[ImGuiCol_TabUnfocused] = ImVec4(0.06666667014360428f, 0.1019607856869698f, 0.1450980454683304f, 0.9724000096321106f);
	style.Colors[ImGuiCol_TabUnfocusedActive] = ImVec4(0.1333333402872086f, 0.2588235437870026f, 0.4235294163227081f, 1.0f);
	style.Colors[ImGuiCol_PlotLines] = ImVec4(0.6078431606292725f, 0.6078431606292725f, 0.6078431606292725f, 1.0f);
	style.Colors[ImGuiCol_PlotLinesHovered] = ImVec4(1.0f, 0.4274509847164154f, 0.3490196168422699f, 1.0f);
	style.Colors[ImGuiCol_PlotHistogram] = ImVec4(0.2745098173618317f, 0.125490203499794f, 0.8039215803146362f, 1.0f);
	style.Colors[ImGuiCol_PlotHistogramHovered] = ImVec4(0.4245694577693939f, 0.2196577787399292f, 0.9656652212142944f, 1.0f);
	style.Colors[ImGuiCol_TableHeaderBg] = ImVec4(0.1882352977991104f, 0.1882352977991104f, 0.2000000029802322f, 1.0f);
	style.Colors[ImGuiCol_TableBorderStrong] = ImVec4(0.3098039329051971f, 0.3098039329051971f, 0.3490196168422699f, 1.0f);
	style.Colors[ImGuiCol_TableBorderLight] = ImVec4(0.2274509817361832f, 0.2274509817361832f, 0.2470588237047195f, 1.0f);
	style.Colors[ImGuiCol_TableRowBg] = ImVec4(0.0f, 0.0f, 0.0f, 0.0f);
	style.Colors[ImGuiCol_TableRowBgAlt] = ImVec4(1.0f, 1.0f, 1.0f, 0.05999999865889549f);
	style.Colors[ImGuiCol_TextSelectedBg] = ImVec4(0.2745098173618317f, 0.125490203499794f, 0.8039215803146362f, 1.0f);
	style.Colors[ImGuiCol_DragDropTarget] = ImVec4(0.4245694577693939f, 0.2196577787399292f, 0.9656652212142944f, 1.0f);
	style.Colors[ImGuiCol_NavHighlight] = ImVec4(0.2588235437870026f, 0.5882353186607361f, 0.9764705896377563f, 1.0f);
	style.Colors[ImGuiCol_NavWindowingHighlight] = ImVec4(1.0f, 1.0f, 1.0f, 0.699999988079071f);
	style.Colors[ImGuiCol_NavWindowingDimBg] = ImVec4(0.800000011920929f, 0.800000011920929f, 0.800000011920929f, 0.2000000029802322f);
	style.Colors[ImGuiCol_ModalWindowDimBg] = ImVec4(0.800000011920929f, 0.800000011920929f, 0.800000011920929f, 0.3499999940395355f);
}