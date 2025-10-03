# PickRandomCardsMAUI

This is a test file for experimenting with git commands.

- Add, commit, push, pull, branch, merge, and more!
- Feel free to edit or delete this content.

Happy testing!

## how to work with git

Below are concise, practical git commands and workflows you can use while working on this project. Examples are written for Windows PowerShell (use the same commands in Bash/macOS with minor differences).

1) Basic local workflow

- Initialize a repository (only needed once):

	git init

- Check status and see what changed:

	git status

- Stage files for commit:

	git add <file-or-path>

- Commit staged changes with a message:

	git commit -m "Short, meaningful message"

2) Working with branches

- Create and switch to a new branch:

	git checkout -b feat/your-feature

- List branches:

	git branch --all

- Switch to an existing branch:

	git checkout main

3) Syncing with a remote (GitHub)

- Add a remote (only once):

	git remote add origin https://github.com/<username>/<repo>.git

- Fetch remote branches and history:

	git fetch origin

- Push a branch and set upstream (first push for a branch):

	git push -u origin feat/your-feature

- Pull remote changes into your current branch:

	git pull origin main

4) Updating a branch with main (merge or rebase)

- Merge main into your branch (keeps history and creates a merge commit):

	git checkout feat/your-feature
	git fetch origin
	git merge origin/main

- Rebase your branch onto main (linear history):

	git checkout feat/your-feature
	git fetch origin
	git rebase origin/main

5) Common tasks and tips

- Amend the previous commit (if not yet pushed):

	git commit --amend --no-edit

- View commit log (compact):

	git log --oneline --graph --decorate --all

- Stash changes temporarily:

	git stash push -m "WIP: short note"
	git stash pop

- Discard local changes to a file:

	git checkout -- <file>

- Create a patch/diff to share:

	git format-patch origin/main..HEAD

6) Collaboration etiquette

- Keep commits small and focused.
- Use clear branch names (e.g., feat/, fix/, chore/).
- Open pull requests for review; write a short description of what changed and why.
- Rebase or merge main as needed before merging to reduce conflicts.

7) Troubleshooting pointers

- To recover from a bad rebase, use:

	git rebase --abort

- To undo a local commit but keep changes staged:

	git reset --soft HEAD~1

- To completely reset your branch to match remote main (dangerous):

	git fetch origin
	git reset --hard origin/main

If you'd like, I can also add a short CONTRIBUTING.md with recommended branch naming, PR template, and CI notes.