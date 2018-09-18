using System;
using System.Collections.Generic;
using System.Text;

namespace ImGui.NET.SampleProgram
{
  public static class NodeGraph
  {

    public static void ShowExampleAppCustomNodeGraph(Boolean opened)
    {
      List<Node> nodes = new List<Node>() ;
      List<NodeLink> links;
      bool inited = false;
      System.Numerics.Vector2 scrolling = new System.Numerics.Vector2(0.0f, 0.0f);
      bool show_grid = true;
      int node_selected = -1;

      if (!inited) {
        //nodes.Add(Node(){ })
      }

    }

  }






  /*
  struct Node
  {
    int ID;
    char Name[32];
    ImVec2 Pos, Size;
    float Value;
    ImVec4 Color;
    int InputsCount, OutputsCount;

    Node(int id, const char* name, const ImVec2& pos, float value, const ImVec4& color, int inputs_count, int outputs_count) { ID = id; strncpy(Name, name, 31); Name[31] = 0; Pos = pos; Value = value; Color = color; InputsCount = inputs_count; OutputsCount = outputs_count; }
    ImVec2 GetInputSlotPos(int slot_no) const { return ImVec2(Pos.x, Pos.y + Size.y* ((float) slot_no + 1) / ((float) InputsCount + 1)); }
    ImVec2 GetOutputSlotPos(int slot_no) const { return ImVec2(Pos.x + Size.x, Pos.y + Size.y* ((float) slot_no + 1) / ((float) OutputsCount + 1)); }
  };
  */

  public class Node
  {
    int ID;
    char[] Name;
    System.Numerics.Vector2 Pos;
    System.Numerics.Vector2 Size;
    float Value;
    System.Numerics.Vector4 Color;
    int InputsCount;
    int OutputsCount;

    Node() {
    }
  }






  /*
  struct NodeLink
  {
    int InputIdx, InputSlot, OutputIdx, OutputSlot;
    NodeLink(int input_idx, int input_slot, int output_idx, int output_slot) { InputIdx = input_idx; InputSlot = input_slot; OutputIdx = output_idx; OutputSlot = output_slot; }

  };
  */

  public class NodeLink {
    int InputIdx;
    int InputSlot;
    int OutputIdx;
    int OutputSlot;
  }

}

