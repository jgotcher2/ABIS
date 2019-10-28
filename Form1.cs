using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {< DirectedGraph xmlns = "http://schemas.microsoft.com/vs/2009/dgml" >
  <Nodes>
    <Node Id="(@1 @2)" Visibility="Hidden" />
    <Node Id="(@3 Namespace=WindowsFormsApp1 Type=Form1)" Category="CodeSchema_Class" CodeSchemaProperty_IsPublic="True" CommonLabel="Form1" Icon="Microsoft.VisualStudio.Class.Public" IsDragSource="True" Label="Form1" SourceLocation="(Assembly=&quot;file:///C:/Users/Jacob T Gotcher/Desktop/ABIS/WindowsFormsApp1/Form1.cs&quot; StartLineNumber=12 StartCharacterOffset=25 EndLineNumber=12 EndCharacterOffset=30)" />
  </Nodes>
  <Links>
    <Link Source="(@1 @2)" Target="(@3 Namespace=WindowsFormsApp1 Type=Form1)" Category="Contains" />
  </Links>
  <Categories>
    <Category Id="CodeSchema_Class" Label="Class" BasedOn="CodeSchema_Type" Icon="CodeSchema_Class" />
    <Category Id="CodeSchema_Type" Label="Type" Icon="CodeSchema_Class" />
    <Category Id="Contains" Label="Contains" Description="Whether the source of the link contains the target object" IsContainment="True" />
  </Categories>
  <Properties>
    <Property Id="CodeSchemaProperty_IsPublic" Label="Is Public" Description="Flag to indicate the scope is Public" DataType="System.Boolean" />
    <Property Id="CommonLabel" DataType="System.String" />
    <Property Id="Icon" Label="Icon" DataType="System.String" />
    <Property Id="IsContainment" DataType="System.Boolean" />
    <Property Id="IsDragSource" Label="IsDragSource" Description="IsDragSource" DataType="System.Boolean" />
    <Property Id="Label" Label="Label" Description="Displayable label of an Annotatable object" DataType="System.String" />
    <Property Id="SourceLocation" Label="Start Line Number" DataType="Microsoft.VisualStudio.GraphModel.CodeSchema.SourceLocation" />
    <Property Id="Visibility" Label="Visibility" Description="Defines whether a node in the graph is visible or not" DataType="System.Windows.Visibility" />
  </Properties>
  <QualifiedNames>
    <Name Id="Assembly" Label="Assembly" ValueType="Uri" />
    <Name Id="File" Label="File" ValueType="Uri" />
    <Name Id="Namespace" Label="Namespace" ValueType="System.String" />
    <Name Id="Type" Label="Type" ValueType="System.Object" />
  </QualifiedNames>
  <IdentifierAliases>
    <Alias n="1" Uri="Assembly=$(VsSolutionUri)/WindowsFormsApp1.csproj" />
    <Alias n="2" Uri="File=$(VsSolutionUri)/Form1.cs" />
    <Alias n="3" Uri="Assembly=$(c70ed365-b32d-47fe-bd3d-b6b7aa14230a.OutputPathUri)" />
  </IdentifierAliases>
  <Paths>
    <Path Id="c70ed365-b32d-47fe-bd3d-b6b7aa14230a.OutputPathUri" Value="file:///C:/Users/Jacob T Gotcher/Desktop/ABIS/WindowsFormsApp1/bin/Debug/WindowsFormsApp1.exe" />
    <Path Id="VsSolutionUri" Value="file:///C:/Users/Jacob T Gotcher/Desktop/ABIS/WindowsFormsApp1" />
  </Paths>
</DirectedGraph>
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            lblHelloWorld.Text = "Hello World";
        }

        private void Students_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Answers_Click(object sender, EventArgs e)
        {

        }
    }
}
