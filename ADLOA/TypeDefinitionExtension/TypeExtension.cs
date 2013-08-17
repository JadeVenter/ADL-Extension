using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.Composition;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Presentation;
using Microsoft.VisualStudio.ArchitectureTools.Extensibility.Uml;
using Microsoft.VisualStudio.Modeling.ExtensionEnablement;
using Microsoft.VisualStudio.Uml.Classes;

namespace TypeDefinitionExtension
{
    // Custom context menu command extension
    // See http://msdn.microsoft.com/en-us/library/ee329481(VS.110).aspx
    [Export(typeof(ICommandExtension))]
    [ClassDesignerExtension]
    [ComponentDesignerExtension]
    class TypeExtension : ICommandExtension
    {
        [Import]
        IDiagramContext context { get; set; }

        List<String> types = new List<string>();

        public void Execute(IMenuCommand command)
        {
            // TODO: Add the logic for your command extension here
            frmTypeDefUI typeUI = new frmTypeDefUI(types);

            typeUI.ShowDialog();
            
            // The following example creates a new class in the model store
            // and displays it on the current diagram.
            //IClassDiagram diagram = context.CurrentDiagram as IClassDiagram;
            //IModelStore store = diagram.ModelStore;
            //IPackage rootPackage = store.Root;
            
            //IClass newClass = rootPackage.CreateClass();
            //newClass.Name = "TypeDefinitionExtension";
            //diagram.Display(newClass);
        }

        public void QueryStatus(IMenuCommand command)
        {
            // TODO: Add logic to control the display of your menu item

            // The following example will disable the command extension unless the user selected
            // a class shape.
            //
            //   IShape selshape = context.CurrentDiagram.SelectedShapes.FirstOrDefault();
            //   command.Enabled = selshape.Element is IClass;
            //
            // Note: Setting command.Visible=false can have unintended interactions with other extensions.
        }

        public string Text
        {
            get { return "Define Connector Types"; }
        }
    }
}
