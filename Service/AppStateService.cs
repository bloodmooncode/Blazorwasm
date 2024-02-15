public class AppStateService
  {
      public event Action<bool> OnDrawerStateChanged;

      public bool isDrawerOpen = true;

      public bool IsDrawerOpen
      {
          get => isDrawerOpen;
          set
          {
              if (isDrawerOpen != value)
              {
                  isDrawerOpen = value;
                  NotifyDrawerStateChanged();
              }
          }
      }

      private void NotifyDrawerStateChanged()
      {
          OnDrawerStateChanged?.Invoke(isDrawerOpen);
          
      }
  }