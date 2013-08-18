using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
using Microsoft.VisualStudio.Modeling.ExtensionEnablement;
using Microsoft.VisualStudio.Uml.Classes;
using DefinitionExtension.UI;

namespace DefinitionExtension
{
    // Custom context menu command extension
    // See http://msdn.microsoft.com/en-us/library/ee329481(v=vs.110).aspx
    [Export(typeof(ICommandExtension))]
    [ClassDesignerExtension]
    [ComponentDesignerExtension]
    class SignalExtension : ICommandExtension
    {
        [Import]
        IDiagramContext context { get; set; }

        List<String> rules = new List<string>();

        public void Execute(IMenuCommand command)
        {
            // TODO: Perform whatever you want this extension to do
            //
            // Example:
            //
            //   IClassDiagram diagram = context.CurrentDiagram as IClassDiagram;
            //   IModelStore store = diagram.ModelStore;
            //   IPackage rootPackage = store.Root;
            //   IClass newClass = rootPackage.CreateClass();
            //   newClass.Name = "New Class";
            //   diagram.Display(newClass);

            frmSignalDefinition ruleUI = new frmSignalDefinition(rules);

            ruleUI.ShowDialog();
            
        }

        public void QueryStatus(IMenuCommand command)
        {
            // TODO: Add logic to control the display of your menu item
            // 
            // Example:
            //
            //   IShape selshape = context.CurrentDiagram.SelectedShapes.FirstOrDefault();
            //   command.Enabled = selshape.Element is IClass;
            //
            // Note: Setting command.Visible=false can have unintended interactions with other extensions.
        }

        public string Text
        {
            get { return "Define Signal Logic"; }
        }
    }
}
