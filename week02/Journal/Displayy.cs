using System;

public class Displayy
{
  public Prompt prompt;
  public Displayy(Prompt prompt)
  {
    this.prompt = prompt;
  }
  
  public void Show()
    {
        prompt.DisplayEntries();
    }  
}