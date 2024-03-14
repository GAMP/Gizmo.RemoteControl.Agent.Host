# Gizmo.RemoteControl.Agent.Host

## git

To clone this repository, use the following command:

```bash
git clone https://github.com/GAMP/Gizmo.RemoteControl.Agent.Host.git -b main --recurse-submodules
```

if you already cloned the repository and want to update the submodules, use the following command:

```bash
git pull --recurse-submodules
```

Update the submodules manually, use the following command:

```bash
git submodule update --init --remote --recursive
```

Add a submodule, use the following command:

```bash
git submodule add -b main https://github.com/GAMP/Gizmo.Lib.git Submodules/Gizmo.Lib
```

Remove a submodule, use the following command:

```bash
git submodule deinit -f -- ./Submodules/Gizmo.Lib
git rm -f ./Submodules/Gizmo.Lib
```

Remove all submodules, use the following command:

```bash
git submodule deinit -f -- ./Submodules/*
git rm -f ./Submodules/*
```

#
