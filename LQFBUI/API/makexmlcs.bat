xsd.exe /c initiative.xsd
xsd.exe /c area.xsd
sed s/initiative_listInitiative/Initiative/g initiative.cs > initiative.cs.fix
mv -f initiative.cs.fix initiative.cs
sed s/area_listArea/Area/g area.cs > area.cs.fix
mv -f area.cs.fix area.cs