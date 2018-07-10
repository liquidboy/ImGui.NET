using System;
using System.Collections.Generic;
using System.Text;

namespace JF.UI
{
  public static partial class Controls
  {
    public static void ToggleButton(string id, ref bool isChecked, bool rounded = true) {
      
      var p = ImGuiNET.ImGui.GetCursorScreenPos();
      var draw_list = ImGuiNET.ImGui.GetOverlayDrawList();

      var height = ImGuiNET.ImGui.GetFrameHeight()+5;
      var width = height * 1.85f ;
      var radius = height * 0.50f;
      int col_shade_dif = 40;
      var padding = 2.0f;

      if (ImGuiNET.ImGui.InvisibleButton(id, new System.Numerics.Vector2(width, height)))
        isChecked = !isChecked;

      uint col_bg;
      if (ImGuiNET.ImGui.IsItemHovered(ImGuiNET.HoveredFlags.RectOnly))
        col_bg = isChecked? IM_COL32(145 + col_shade_dif, 211, 68 + col_shade_dif, 255) : IM_COL32(218 - col_shade_dif, 218 - col_shade_dif, 218 - 20, 255);
      else
        col_bg = isChecked ? IM_COL32(145, 211, 68, 255) : IM_COL32(218, 218, 218, 255);

      if (rounded)
      {
        draw_list.AddRectFilled(p, new System.Numerics.Vector2(p.X + width, p.Y + height), col_bg, height * 0.5f);
        draw_list.AddCircleFilled(new System.Numerics.Vector2(isChecked ? (p.X + width - radius) : (p.X + radius), p.Y + radius), radius - padding, IM_COL32(255, 255, 255, 255));
      }
      else {
        draw_list.AddRectFilled(p, new System.Numerics.Vector2(p.X + width + padding, p.Y + height), col_bg, height * 0.5f, 0);
        var thumbWidth = width * 0.5f - padding;
        var thumbX = isChecked ? (p.X + thumbWidth + (2 * padding)) : (p.X + padding);
        var thumbY = p.Y + padding;
        var thumbHeight = height - (2 * padding);
        draw_list.AddRectFilled(new System.Numerics.Vector2(thumbX, thumbY), new System.Numerics.Vector2(thumbX + thumbWidth, thumbY + thumbHeight),IM_COL32(255, 255, 255, 255), 0);
      }
      
    }
  }
}




//void ToggleButton(const char* str_id, bool* v)
//{
//  ImVec2 p = ImGui::GetCursorScreenPos();
//  ImDrawList* draw_list = ImGui::GetWindowDrawList();

//  float height = ImGui::GetFrameHeight();
//  float width = height * 1.55f;
//  float radius = height * 0.50f;

//  if (ImGui::InvisibleButton(str_id, ImVec2(width, height)))
//    *v = !*v;
//  ImU32 col_bg;
//  if (ImGui::IsItemHovered())
//    col_bg = *v ? IM_COL32(145 + 20, 211, 68 + 20, 255) : IM_COL32(218 - 20, 218 - 20, 218 - 20, 255);
//  else
//    col_bg = *v ? IM_COL32(145, 211, 68, 255) : IM_COL32(218, 218, 218, 255);

//  draw_list->AddRectFilled(p, ImVec2(p.x + width, p.y + height), col_bg, height * 0.5f);
//  draw_list->AddCircleFilled(ImVec2(*v ? (p.x + width - radius) : (p.x + radius), p.y + radius), radius - 1.5f, IM_COL32(255, 255, 255, 255));
//}
